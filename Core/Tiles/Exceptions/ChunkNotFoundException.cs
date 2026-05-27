using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Tiles.Exceptions
{
    /// <summary>
    /// Raises an exception because a chunk couldn't be found by the executable.
    /// </summary>
    internal class ChunkNotFoundException: Exception
    {
        public ChunkNotFoundException() : base() { }

        public ChunkNotFoundException(string message) : base(message) { }

        public ChunkNotFoundException(string message,  Exception innerException) : base(message, innerException) { }

    }
}
