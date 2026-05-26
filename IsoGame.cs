using CAT_Engine.Core.Assets;
using CAT_Engine.Core.Debug;
using CAT_Engine.Core.Debug.Profiling;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CAT_Engine
{
    public class IsoGame : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private Color graphicsDeviceClearColor = Color.Red;

        public AssetManager assetManager;

        public IsoGame()
        {
            graphics = new GraphicsDeviceManager(this);
        }

        //Base functions are sealed as to not disturb the IsoGame engine initialization
        protected sealed override void Initialize()
        {
            using var _ = new IsoScopeCycleStat("Engine.Init");

            assetManager = new AssetManager();
            Window.Title = "IsoBase Game - CAT Engine";
            Window.AllowUserResizing = true;

            base.Initialize();

            OnInitializeWindow(Window);
        }

        protected sealed override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

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

            OnUpdate((float)gameTime.ElapsedGameTime.TotalMilliseconds);
        }

        protected sealed override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(graphicsDeviceClearColor);
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
