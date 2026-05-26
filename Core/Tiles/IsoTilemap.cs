using CAT_Engine.Core.Debug;
using CAT_Engine.Core.Rendering;
using CAT_Engine.Core.Rendering.Interfaces;
using CAT_Engine.Core.Tiles.TileObjects;
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
    public class IsoTilemap : IsoRenderInterface
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

        public void Render(IsoRenderContext ctx)
        {
            using var _ = new IsoScopeCycleStat("Tilemap.Render");
            return;
        }

        public IsoRenderContext GetRenderContext()
        {
            throw new NotImplementedException();
        }
    }
}
