using CAT_Engine;
using CAT_Engine.Core.Debug;
using Microsoft.Xna.Framework;

namespace CATSandboxGame
{
    public class SandboxGame : IsoGame
    {
        public SandboxGame() { }

        protected override void OnInitializeWindow(GameWindow Window)
        {
            Window.Title = "My so cool sandbox game!! :3";
            Window.AllowUserResizing = true;
            IsMouseVisible = true;
        }

        protected override void OnInitializeGame()
        {
            SetGraphicsDeviceClearColor(Color.Blue);
        }

        protected override void OnAssetManagerReady()
        {
            IsoLogger.Log("Content Root Dir test = {0}", assetManager.GetRootDirectoryPath());
            IsoLogger.Log("if this is a full path, great!");
        }
    }
}
