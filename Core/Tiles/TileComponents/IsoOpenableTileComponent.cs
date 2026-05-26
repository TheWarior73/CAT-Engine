using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAT_Engine.Core.Tiles.Interfaces;

namespace CAT_Engine.Core.Tiles.TileComponents
{
    public class IsoOpenableTileComponent : IsoTileComponent, IsoTileComponentInterface
    {
        public bool isOpen;
        public string openedTexture;
        public string closedTexture;

        // Interface implementation
        public string GetTexture() => isOpen ? openedTexture : closedTexture;
    }
}
