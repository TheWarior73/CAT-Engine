using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Utility
{
    public struct IntVector2
    {
        public int x;
        public int y;

        public IntVector2() { }
        public IntVector2(int x, int y) 
        { 
            this.x = x;
            this.y = y;
        }

        public static IntVector2 Zero() => new IntVector2(0, 0);
        //public static IntVector2 Identity() => new IntVector2(1, 1);

        public override int GetHashCode()
        {
            return HashCode.Combine(x, y);
        }

        public override bool Equals(object obj)
        {
            return obj is IntVector2 v && v.x == x && v.y == y;
        }
    }

    public struct IntVector3
    {
        public int x;
        public int y;
        public int z;

        public IntVector3() { }
        public IntVector3(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static IntVector3 Zero() => new IntVector3(0, 0, 0);
        //public static IntVector3 Identity() => new IntVector2(1, 1, 1);

        public override int GetHashCode()
        {
            return HashCode.Combine(x, y, z);
        }

        public override bool Equals(object obj)
        {
            return obj is IntVector3 v && v.x == x && v.y == y && v.z == z;
        }
    }
}
