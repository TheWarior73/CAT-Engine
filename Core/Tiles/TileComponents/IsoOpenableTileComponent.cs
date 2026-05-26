using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Tiles.TileComponents
{
    public class IsoOpenableTileComponent : IsoTileComponent
    {
        public bool isOpen;
        public string openedTexture;
        public string closedTexture;

        string GetTexture() => isOpen ? openedTexture : closedTexture;
    }
}
