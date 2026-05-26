using CAT_Engine.Core.Debug;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.IO;

namespace CAT_Engine.Core.Assets
{
    public class AssetManager
    {
        private IServiceProvider service = null;
        private ContentManager contentManager = null;

        protected static string tileTexturePath = Path.Combine("tiles");

        public AssetManager()
        {
            using var _ = new IsoScopeCycleStat("AssetManager.Constructor");

            service = new GameServiceContainer();
            contentManager = new ContentManager(service);
            contentManager.RootDirectory = "Content";
        }

        public T LoadAsset<T>(string assetName)
        {
            return (T)contentManager.Load<T>(assetName);
        }

        public void UnloadAsset(string assetName)
        {
            contentManager.UnloadAsset(assetName);
        }

        public Texture2D LoadTileTexture(string tileId)
        {
            return LoadAsset<Texture2D>(tileTexturePath +  tileId);
        }

        public string GetRootDirectoryPath(bool absolute = true)
        {
            return absolute? Path.GetFullPath(contentManager.RootDirectory) : contentManager.RootDirectory;
        }
    }
}
