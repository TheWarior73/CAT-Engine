using CAT_Engine.Core.Tiles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace CAT_Engine.Core.Tiles.TileObjects
{
    public class IsoRenderableTileObject : IsoTileObject, IsoRenderableTileComponentInterface
    {
        public IsoRenderableTileObject() { }

        private string currentTextureId = "base";

        public string GetTextureID()
        {
            return currentTextureId;
        }

        public void SetTextureID(string textureID) => currentTextureId = textureID;
    }
}
