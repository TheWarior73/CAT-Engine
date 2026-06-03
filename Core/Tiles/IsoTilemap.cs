using CAT_Engine.Core.Debug;
using CAT_Engine.Core.Rendering;
using CAT_Engine.Core.Rendering.Interfaces;
using CAT_Engine.Core.Tiles.Exceptions;
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
    public class IsoTilemap
    {
        public IsoTilemap() { }

        public Dictionary<IntVector2, IsoTileChunk> chunks = new();

        public const int TILE_WIDTH = 32;
        public const int TILE_HEIGHT = 32;

        /// <summary>
        /// Creates a chunk on the TileMap to the given coordinates and returns it
        /// </summary>
        /// <param name="ChunkPosition">The chunk's x and y position</param>
        /// <returns>The newly created Chunk</returns>
        public IsoTileChunk CreateChunk(IntVector2 ChunkPosition)
        {
            IsoTileChunk newChunk = new(ChunkPosition);

            return newChunk;
        }

        // TODO!
        public IsoRenderContext GetRenderContext()
        {
            throw new NotImplementedException();
        }

        #region Addition/Removal of objects
        // Add/Remove of an Object to the map

        /// <summary>
        /// Adds an object to the Tile Map
        /// </summary>
        /// <param name="obj">The TileObject to be added to the map</param>
        /// <param name="globalPos">The Global Position of the object to be added</param>
        public void AddObject(IsoTileObject obj, IntVector3 globalPos)
        {
            IntVector2 chunkPos = IsoTileChunk.CalculateChunkCoords(globalPos);
            IntVector2 localPos = IsoTileZStack.CalculateSquareCoordinatesInZstack(globalPos);

            // Get/Create the chunk
            IsoTileChunk currentChunk = null;
            if (!chunks.TryGetValue(chunkPos, out IsoTileChunk foundChunk))
            {
                currentChunk = CreateChunk(chunkPos);
                chunks.Add(chunkPos, currentChunk);
            }
            else
            {
                currentChunk = foundChunk;
            }

            // Get/Create the ZStack
            IsoTileZStack currentStack = null;
            if (!currentChunk.stacks.TryGetValue(globalPos.z, out IsoTileZStack foundStack))
            {
                currentStack = currentChunk.CreateZStack(globalPos.z);    
            }
            else 
            {
                currentStack = foundStack;
            }

            // Get/Create the Square
            IsoTileSquare currentSquare = null;
            if (currentStack.squares[localPos.x, localPos.y] == null)
            {
                currentSquare = currentStack.CreateTileSquare(globalPos);
            }
            else
            {
                currentSquare = currentStack.squares[localPos.x, localPos.y];
            }

            // Finally, Add the Object to the square
            currentSquare.AddTileObject(obj);
        }

        /// <summary>
        /// Removes an object from the Tile Map
        /// </summary>
        /// <param name="obj">The TileObject to be removed from the map</param>
        /// <param name="globalPos">The Global Position of the object to be removed</param>
        public void RemoveObject(IsoTileObject obj, IntVector3 globalPos)
        {
            // Get Chunk, ZStack, Square and finally Object.
            IntVector2 chunkPos = IsoTileChunk.CalculateChunkCoords(globalPos);
            IntVector2 localPos = IsoTileZStack.CalculateSquareCoordinatesInZstack(globalPos);

            IsoTileChunk currentChunk = chunks[chunkPos];
            IsoTileZStack currentStack = null;
            IsoTileSquare currentSquare = null;

            // ---
            if (currentChunk != null)
            {
                currentStack = currentChunk.stacks[globalPos.z];
                if (currentStack != null)
                {
                    currentSquare = currentStack.squares[localPos.x, localPos.y];

                    if (currentSquare != null)
                    {
                        if (currentSquare.objects.Contains(obj))
                        {
                            currentSquare.objects.Remove(obj);
                        }
                    } 
                    else
                    {
                        throw new SquareNotFoundException("IsoTilemap - RemoveObject : Square not found");
                    }
                }
                else
                {
                    throw new ZStackNotFoundException("IsoTilemap - RemoveObject : Stack not found");
                }
            } else
            {
                throw new ChunkNotFoundException("IsoTilemap - RemoveObject : Chunk not found");
            }

            // If Square is empty, remove
            if (currentSquare.IsEmpty())
            {
                currentStack.RemoveTileSquare(globalPos);
            }

            // If ZStack is empty, remove
            if (currentStack.IsEmpty())
            {
                currentChunk.RemoveZStack(globalPos.z);
            }

            // If Chunk  is empty, remove
            if (currentChunk.IsEmpty())
            {
                chunks.Remove(chunkPos);
            }

            // End;
        }
        #endregion

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("Chunks in tileMap:");

            int count = 0;
            foreach (var chunk in chunks)
            {
                sb.AppendLine("(" + count++ + ")");
                sb.AppendLine("- Key: " + chunk.Key);
                sb.AppendLine("- Value:");

                string valueStr = chunk.Value?.ToString() ?? "null";
                valueStr = valueStr.Replace("\n", "\n\t");

                sb.AppendLine("\t" + valueStr);
            }

            sb.Replace("\n", "\n\t");
            return sb.ToString();
        }
    }
}
