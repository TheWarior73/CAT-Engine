using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Tiles.Definitions
{
    public class TileDefinition
    {
        protected TileDefinition() { }

        public string name;
        public string texturePath;

        public virtual void SetDefaults()
        {
            name = "Tile";
            texturePath = "tiles/default";
        }
    }

    public class FloorGrass : TileDefinition
    {
        public override void SetDefaults()
        {
            name = "Grass Floor";
            texturePath = "tiles/floor_grass";
        }
    }
}
