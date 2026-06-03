using System;
using System.Collections.Generic;
using System.Text;
using CAT_Engine.Core.Tiles.TileObjects;
using CAT_Engine.Core.Utility;

namespace CAT_Engine.Core.Tiles
{
    /// <summary>
    /// Represents an Isometric Tile Square
    /// A Square contains a List of <see cref="IsoTileObject"/>
    /// </summary>
    public class IsoTileSquare
    {
        public IsoTileSquare() { }
        public List<IsoTileObject> objects = new();

        public void AddTileObject(IsoTileObject obj)
        {
            objects.Add(obj);

            // Let the object know that it's parent has been updated
            obj.OnAddedToSquare(this);
        }

        /// <summary>
        /// Creates and adds a new Tile Object to a Tile Square
        /// </summary>
        /// <returns></returns>
        public IsoTileObject CreateTileObject()
        {
            return new IsoTileObject();
        }

        /// <summary>
        /// Removes a specified Tile Object from a square
        /// </summary>
        /// <param name="obj">The object to be removed from the square</param>
        public void RemoveTileObject(IsoTileObject obj)
        {
            objects.Remove(obj);
        }

        /// <summary>
        /// Clears the square from it's objects
        /// </summary>
        public void ClearSquare()
        {
            objects.Clear();
        }

        /// <summary>
        /// Checks if the Square is empty
        /// </summary>
        /// <returns>The check result (True if empty, False otherwise)</returns>
        public bool IsEmpty()
        {
            return objects.Count == 0;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("- Objects in Square:");

            int count = 0;
            foreach (IsoTileObject obj in objects)
            {
                sb.AppendLine("(" + count++ + ")");
                sb.AppendLine("- Value:");

                string valueStr = obj.ToString();
                valueStr = valueStr.Replace("\n", "\n\t");

                sb.AppendLine("\t" + valueStr);
            }

            sb.Replace("\n", "\n\t");
            return sb.ToString();
        }
    }

    /// <summary>
    /// Represents an Isometric Chunk Layer
    /// </summary>
    public class IsoTileZStack
    {
        public IsoTileZStack() { }

        //96x96 = 9.216 TOTAL Tiles in a Stack
        public static byte ZSTACK_MAX_X = 96;
        public static byte ZSTACK_MAX_Y = 96;

        private int occupiedSquareCount = 0;
        public IsoTileSquare[,] squares = new IsoTileSquare[ZSTACK_MAX_X, ZSTACK_MAX_Y];

        /// <summary>
        /// Converts the global coordinates of a square to a local chunk coordinate
        /// </summary>
        /// <param name="globalPos">The global position of the square</param>
        /// <returns></returns>
        public static IntVector2 CalculateSquareCoordinatesInZstack(IntVector3 globalPos)
        {
            IntVector2 stackPos = new();
            stackPos.x = globalPos.x % ZSTACK_MAX_X;
            stackPos.y = globalPos.y % ZSTACK_MAX_Y;

            return stackPos;
        }

        /// <summary>
        /// Creates and adds a new <see cref="IsoTileSquare"/> to a <see cref="IsoTileZStack"/>
        /// </summary>
        /// <param name="globalPos">The global position of the square to be created</param>
        /// <returns>The newly created square</returns>
        /// <exception cref="Exception"></exception>
        public IsoTileSquare CreateTileSquare(IntVector3 globalPos)
        {
            IsoTileSquare newTileSquare = null;

            IntVector2 chunkPos = CalculateSquareCoordinatesInZstack(globalPos);

            // If there is no square on the coordinates, we add it.
            if (squares[chunkPos.x, chunkPos.y] == null)
            {
                newTileSquare = new IsoTileSquare();
                squares[chunkPos.x, chunkPos.y] = newTileSquare;
                occupiedSquareCount++;
            }
            else // There is already a square !
            {
                throw new Exception("CreateTileSquare: A TileSquare already exists at (global)Pos (" + globalPos.x + ", " + globalPos.y + ")");
            }

            return newTileSquare;
        }

        /// <summary>
        /// Removes a <see cref="IsoTileSquare"/> from a <see cref="IsoTileZStack"/>
        /// </summary>
        /// <param name="globalPos">The global position of the square to be removed</param>
        public void RemoveTileSquare(IntVector3 globalPos)
        {
            IntVector2 chunkPos = CalculateSquareCoordinatesInZstack(globalPos);

            squares[chunkPos.x, chunkPos.y] = null;
            occupiedSquareCount--;
        }

        /// <summary>
        /// Clears the ZStack's square list.
        /// </summary>
        public void ClearStack()
        {
            squares = new IsoTileSquare[ZSTACK_MAX_X, ZSTACK_MAX_Y];
        }

        /// <summary>
        /// Checks if the ZStack is empty
        /// </summary>
        /// <returns>The check result (True if empty, False otherwise)</returns>
        public bool IsEmpty()
        {
            return occupiedSquareCount == 0;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("- Occupied Square Count: " + occupiedSquareCount);
            sb.AppendLine("- Squares in ZStack:");

            int count = 0;

            for (int i = 0; i < ZSTACK_MAX_X; i++)
            {
                for (int j = 0; j < ZSTACK_MAX_Y; j++)
                {
                    IsoTileSquare square = squares[i, j];

                    if (square != null)
                    {
                        StringBuilder tempBuilder = new();

                        tempBuilder.AppendLine("(" + count++ + ")");
                        tempBuilder.AppendLine("- Position: " + new IntVector2(i, j).ToString());
                        tempBuilder.AppendLine("- Value:");

                        string valueStr = square.ToString();
                        valueStr = valueStr.Replace("\n", "\n\t");

                        tempBuilder.Append("\t" + valueStr);

                        tempBuilder.Replace("\n", "\n\t");
                        sb.AppendLine("\t" + tempBuilder.ToString());
                    }
                }
            }

            return sb.ToString();
        }

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
        public Dictionary<int, IsoTileZStack> stacks = new();

        /// <summary>
        /// Calculates the chunk coordinates in the world relative to a global position
        /// </summary>
        /// <param name="globalPos"></param>
        /// <returns></returns>
        public static IntVector2 CalculateChunkCoords(IntVector3 globalPos)
        {
            IntVector2 chunkPos = new();

            chunkPos.x = (int)Math.Floor((float)globalPos.x / IsoTileZStack.ZSTACK_MAX_X);
            chunkPos.y = (int)Math.Floor((float)globalPos.y / IsoTileZStack.ZSTACK_MAX_Y);

            return chunkPos;
        }

        public IsoTileZStack CreateZStack(int zIndex)
        {
            IsoTileZStack newZStack = null;

            // If stack is free at this index, we create a new stack and add it
            if (stacks != null || (!stacks?.ContainsKey(zIndex) ?? false))
            {
                newZStack = new();
                stacks[zIndex] = newZStack;
            }
            else // If stack is not free, we throw an Exception
            {
                throw new Exception("CreateZStack: zStack already has a member at index " + zIndex);
            }

            return newZStack;
        }

        public void RemoveZStack(int zIndex)
        {
            stacks?.Remove(zIndex); // Will throw an exception is the index does not exist in the stack
        }

        /// <summary>
        /// Clears the chunk Stacks
        /// </summary>
        public void ClearChunk()
        {
            stacks = new Dictionary<int, IsoTileZStack>();
        }

        /// <summary>
        /// Checks if the chunk is empty
        /// </summary>
        /// <returns>The check result (True if empty, False otherwise)</returns>
        public bool IsEmpty()
        {
            return stacks?.Count == 0;
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            // Optional, depends on usage really.
            sb.AppendLine("- Position: " + chunkPosition.ToString());
            sb.AppendLine("- Stacks in chunk:");

            int count = 0;
            foreach (var stack in stacks)
            {
                StringBuilder tempBuilder = new();

                tempBuilder.AppendLine("(" + count++ + ")");
                tempBuilder.AppendLine("- Key (z-index): " + stack.Key);
                tempBuilder.AppendLine("- Value:");

                // Grab the string and indent all internal newlines
                string valueStr = stack.Value?.ToString() ?? "null";
                valueStr = valueStr.Replace("\n", "\n\t");

                tempBuilder.Append("\t" + valueStr);
                tempBuilder.Replace("\n", "\n\t");
                sb.AppendLine("\t" + tempBuilder.ToString());
            }

            return sb.ToString();
        }
    }
}
