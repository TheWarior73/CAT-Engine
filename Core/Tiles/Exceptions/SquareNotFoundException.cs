using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Tiles.Exceptions
{
    /// <summary>
    /// Raises an exception because a Square couldn't be found by the executable.
    /// </summary>
    internal class SquareNotFoundException : Exception
    {
        public SquareNotFoundException() : base() { }

        public SquareNotFoundException(string message) : base(message) { }

        public SquareNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }
}
