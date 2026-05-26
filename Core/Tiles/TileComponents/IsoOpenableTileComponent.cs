using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAT_Engine.Core.Tiles.Interfaces;

namespace CAT_Engine.Core.Tiles.TileComponents
{
    public class IsoOpenableTileComponent : IsoRenderableTileComponentInterface
    {
        public bool isOpen = false;
        public string openedTexture = "window_open";
        public string closedTexture = "window_closed";

        // Interface implementation
        public string GetTextureID() => isOpen ? openedTexture : closedTexture;
    }
}
