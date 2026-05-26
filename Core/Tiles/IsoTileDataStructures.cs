using CAT_Engine.Core.Tiles.TileComponents;
using CAT_Engine.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Tiles
{
    public class IsoTileObject
    {
        IsoTileObject() {}

        public string id;
        public List<IsoTileComponent> components;
    }

    public class IsoTileSquare
    {
        public IsoTileSquare() {}
        public List<IsoTileObject> objects = new List<IsoTileObject>();
    }

    public class IsoTileChunk
    {
        public IsoTileChunk(IntVector2 chunkPosition)
        {
            this.chunkPosition = chunkPosition;
        }

        public IntVector2 chunkPosition;
        public Dictionary<IntVector3, IsoTileSquare> tiles;
    }
}
