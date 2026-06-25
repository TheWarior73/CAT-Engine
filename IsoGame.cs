using CAT_Engine.Core.Assets;
using CAT_Engine.Core.Debug;
using CAT_Engine.Core.Debug.Profiling;
using CAT_Engine.Core.Input;
using CAT_Engine.Core.SceneBase;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Globalization;

namespace CAT_Engine
{
    public class IsoGame : Game
    {
        public static IsoGame Instance { get; private set; }

        protected IsoGame()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.ApplyChanges();
            Instance = this;
        }

        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private Color graphicsDeviceClearColor = Color.Red;

        public static AssetManager assetManager;
        internal InputManager inputManager;

        //Base functions are sealed as to not disturb the IsoGame engine initialization
        protected sealed override void Initialize()
        {
            using var _ = new IsoScopeCycleStat("Engine.Init");

            SetLocaleDefaults();

            assetManager = new AssetManager();
            Window.Title = "CAT Engine";

            IsoSceneManager.graphicsDevice = graphics.GraphicsDevice;
            IsoSceneManager.PreInit();

            inputManager = new InputManager();

            #region InputMGR test (to be removed)

            bool isPauseMenuOpen = false;

            inputManager.AddActionMapping("Jump", new[] { new InputChord(Keys.Space) });
            inputManager.AddActionMapping("Pause", new[] { new InputChord(Keys.Tab) }); // escape closes the game as of right now lmao ;( and I can't be bothered to change that (it's like 50 lines down from there, maybe more)
            inputManager.AddActionMapping("Interact", new[] { new InputChord(Keys.F) });

            // W = Forward (+1), S = Backward (-1)
            inputManager.AddAxisMapping("MoveForward", new[] {
                new Axis { scale = 1.0f, keybinds = new[] { new InputChord(Keys.W) } },
                new Axis { scale = -1.0f, keybinds = new[] { new InputChord(Keys.S) } }
            });

            // A = Left (-1), D = Right (+1)
            inputManager.AddAxisMapping("MoveRight", new[] {
                new Axis { scale = 1.0f, keybinds = new[] { new InputChord(Keys.D) } },
                new Axis { scale = -1.0f, keybinds = new[] { new InputChord(Keys.A) } }
            });

            // --- 3. SUBSCRIBE THE ISOLOGGER ---

            // Hook up "Pause" Pressed
            inputManager.RegisterActionPressed("Pause", 0, (e) =>
            {
                isPauseMenuOpen = !isPauseMenuOpen;
                IsoLogger.Log($"ACTION PRESSED: {e.actionName}. isPauseMenuOpen state: {isPauseMenuOpen}", IsoLogger.ELogVerbosity.Warning);

                e.Consume();
            });

            // Hook up "Jump" Pressed
            inputManager.RegisterActionPressed("Jump", 0, (e) =>
            {
                IsoLogger.Log($"ACTION PRESSED: {e.actionName}", IsoLogger.ELogVerbosity.Warning);
            });

            // Hook up "Jump" Released
            inputManager.RegisterActionReleased("Jump", 0, (e) =>
            {
                IsoLogger.Log($"ACTION RELEASED: {e.actionName}", IsoLogger.ELogVerbosity.Warning);
            });

            // Hook up "MoveForward" Axis
            inputManager.RegisterAxisUpdated("MoveForward", 0, (e) =>
            {
                IsoLogger.Log($"AXIS HOLD: {e.axisName} | Value: {e.value}", IsoLogger.ELogVerbosity.Warning);
            });

            // Hook up "MoveRight" Axis
            inputManager.RegisterAxisUpdated("MoveRight", 0, (e) =>
            {
                IsoLogger.Log($"AXIS HOLD: {e.axisName} | Value: {e.value}", IsoLogger.ELogVerbosity.Warning);
            });

            // --- 4. REGISTER PLAYER (Priority: 100 - Runs Last) ---
            inputManager.RegisterActionPressed("Interact", 100, (e) =>
            {
                // The player should ONLY see this if the menu is closed!
                IsoLogger.Log("🎮 PLAYER: I interacted with the game world!", IsoLogger.ELogVerbosity.Warning);
            });

            // --- 5. REGISTER UI MENU (Priority: 0 - Runs First) ---
            inputManager.RegisterActionPressed("Interact", 0, (e) =>
            {
                if (isPauseMenuOpen)
                {
                    IsoLogger.Log("🖥️ UI MENU: The menu is open! Consuming the event so the player doesn't move.", IsoLogger.ELogVerbosity.Warning);

                    e.Consume();
                }
                else
                {
                    IsoLogger.Log("🖥️ UI MENU: Menu is closed. carrying on", IsoLogger.ELogVerbosity.Warning);
                }
            });
            #endregion

            base.Initialize();
            OnInitializeWindow(Window);
        }

        private void SetLocaleDefaults()
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;
        }

        protected sealed override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            IsoSceneManager.spriteBatch = spriteBatch;
            IsoSceneManager.graphicsDevice = GraphicsDevice;

            OnInitializeGame();
            OnAssetManagerReady();
        }

        protected sealed override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            IsoProfiler.Dump();
            IsoProfiler.Reset();

            float deltaTime = (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            inputManager.Update(deltaTime);

            IsoSceneManager.Update(deltaTime);

            OnUpdate(deltaTime);
        }

        protected sealed override void Draw(GameTime gameTime)
        {
            using var _ = new IsoScopeCycleStat("Engine.Draw");

            GraphicsDevice.Clear(graphicsDeviceClearColor);

            IsoSceneManager.RenderActiveScene();
        }

        //This is what the game hooks into:

        /// <summary>
        /// Called after the Engine sets up the Window and lets control to the user. Setup stuff here like <see cref="Game.IsMouseVisible"/> or <see cref="GameWindow.AllowUserResizing"/>
        /// </summary>
        /// <param name="Window"></param>
        protected virtual void OnInitializeWindow(GameWindow Window) { }

        /// <summary>
        /// Called when the Game is ready to initialize. Runs before Asset Manager
        /// </summary>
        protected virtual void OnInitializeGame() { }

        /// <summary>
        /// Called when the Asset Manager is ready for use. Runs after Game Init
        /// </summary>
        protected virtual void OnAssetManagerReady() { }

        /// <summary>
        /// Called when the engine updates.
        /// </summary>
        /// <param name="delta"></param>
        protected virtual void OnUpdate(float delta) { }

        protected void SetGraphicsDeviceClearColor(Color newClearColor)
        {
            graphicsDeviceClearColor = newClearColor;
        }

        //Rendering should mostly be handled by engine so ill leave this commented for now
        //protected virtual void OnRender(float delta) { }
    }
}
