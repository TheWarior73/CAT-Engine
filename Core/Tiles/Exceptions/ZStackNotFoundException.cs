using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Tiles.Exceptions
{
    /// <summary>
    /// Raises an exception because a ZStack couldn't be found by the executable.
    /// </summary>
    internal class ZStackNotFoundException : Exception
    {
        public ZStackNotFoundException() : base() { }

        public ZStackNotFoundException(string message) : base(message) { }

        public ZStackNotFoundException(string message, Exception innerException) : base(message, innerException) { }

    }
}
