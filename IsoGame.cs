using CAT_Engine.Core.Assets;
using CAT_Engine.Core.Config;
using CAT_Engine.Core.Config.Ini;
using CAT_Engine.Core.Debug;
using CAT_Engine.Core.Debug.Profiling;
using CAT_Engine.Core.Rendering;
using CAT_Engine.Core.SceneBase;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
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

        //Base functions are sealed as to not disturb the IsoGame engine initialization
        protected sealed override void Initialize()
        {
            using var _ = new IsoScopeCycleStat("Engine.Init");

            InitializeConfiguration();
            SetLocaleDefaults();

            assetManager = new AssetManager();
            Window.Title = "CAT Engine";

            IsoSceneManager.graphicsDevice = graphics.GraphicsDevice;
            IsoSceneManager.InitializeRenderer(Window);

            base.Initialize();
            OnInitializeWindow(Window);
        }

        private void InitializeConfiguration()
        {
            IniFile defaultEngineIni = ConfigurationManager.GetEngineConfigFile("DefaultEngine.ini");
            
            string logLevel = defaultEngineIni.Read("Verbosity", "Core.Logging");

            bool parsingResult = Enum.TryParse(logLevel, out IsoLogger.ELogVerbosity parsedVerbosity);
            IsoLogger.Assert(parsingResult, "Failed to parse Engine Config");

            IsoLogger.currentVerbosity = parsedVerbosity;
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
