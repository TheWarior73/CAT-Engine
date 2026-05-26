using CAT_Engine.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Tiles
{
    /// <summary>
    /// Represents an Isometric Tile Map made of Tile Chunks
    /// </summary>
    public class IsoTilemap
    {
        public IsoTilemap() { }

        public Dictionary<IntVector2, IsoTileChunk> chunks = new();

        /// <summary>
        /// Creates a chunk on the TileMap to the given coordinates and returns it
        /// </summary>
        /// <param name="ChunkPosition">The chunk's x and y position</param>
        /// <returns>The newly created Chunk</returns>
        public IsoTileChunk AddChunk(IntVector2 ChunkPosition)
        {
            IsoTileChunk newChunk = new IsoTileChunk(ChunkPosition);
            chunks.Add(ChunkPosition, newChunk);

            return newChunk;
        }
    }
}
