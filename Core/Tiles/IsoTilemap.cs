using CAT_Engine.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Tiles
{
    public class IsoTilemap
    {
        public IsoTilemap() { }

        public Dictionary<IntVector2, IsoTileChunk> chunks = new();

        public IsoTileChunk AddChunk(IntVector2 ChunkPosition)
        {
            IsoTileChunk newChunk = new IsoTileChunk(ChunkPosition);
            chunks.Add(ChunkPosition, newChunk);

            return newChunk;
        }
    }
}
