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
    /// A Tile Object contains a list of <see cref="IsoTileComponent"/>'s
    /// </summary>
    public class IsoTileObject
    {
        IsoTileObject() {}

        public string id;
        public List<IsoTileComponent> components;
    }

    /// <summary>
    /// Represents an Isometric Tile Square
    /// A Square contains a List of <see cref="IsoTileObject"/>
    /// </summary>
    public class IsoTileSquare
    {
        public IsoTileSquare() {}
        public List<IsoTileObject> objects = new List<IsoTileObject>();
    }

    public class IsoTileZStack
    {
        public IsoTileZStack() {}

        //96x96 = 9.216 TOTAL Tiles in a Stack
        public static byte ZSTACK_WIDTH = 96;
        public static byte ZSTACK_HEIGHT = 96;

        public IsoTileSquare[,] tiles = new IsoTileSquare[ZSTACK_WIDTH, ZSTACK_HEIGHT];
    }

    /// <summary>
    /// Represents an Isometric Tile Chunk
    /// A Chunk contains a List of <see cref="IsoTileSquare"/>'s
    /// </summary>
    public class IsoTileChunk
    {
        public IsoTileChunk(IntVector2 chunkPosition)
        {
            this.chunkPosition = chunkPosition;
        }

        // Pos of the chunk in the world
        public IntVector2 chunkPosition;

        // Dict of stacks in the chunk
        // Int key = Z Height
        public Dictionary<int, IsoTileZStack> stacks;
    }
}
