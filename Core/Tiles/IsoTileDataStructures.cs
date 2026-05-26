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
    /// <summary>
    /// Represents an Isometric Tile
    /// </summary>
    public class IsoTileObject
    {
        IsoTileObject() {}

        public string id;
        public List<IsoTileComponent> components;
    }

    /// <summary>
    /// Represents an Isometric Tile Square
    /// </summary>
    public class IsoTileSquare
    {
        public IsoTileSquare() {}
        public List<IsoTileObject> objects = new List<IsoTileObject>();
    }

    /// <summary>
    /// Represents an Isometric Tile Chunk
    /// </summary>
    public class IsoTileChunk
    {
        public IsoTileChunk(IntVector2 chunkPosition)
        {
            this.chunkPosition = chunkPosition;
        }

        // Pos of the chunk in the world
        public IntVector2 chunkPosition;

        // Dict of tiles in the chunk
        // 
        public Dictionary<IntVector3, IsoTileSquare> tiles;
    }
}
