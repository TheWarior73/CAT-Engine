using Microsoft.Xna.Framework;
using System;
using System.Text;

namespace CAT_Engine.Core.Utility
{
    /// <summary>
    /// Represents a Vector with 2 dimentions: x and y.<br></br>
    /// Basic comparision operations can be performed, such as == and !=
    /// </summary>
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

        /// <summary>Represents the zero Vector2: (0, 0)</summary>
        public static IntVector2 Zero() => new IntVector2(0, 0);

        /// <summary>Represents the Identity Vector2: (1, 1)</summary>
        //public static IntVector2 Identity() => new IntVector2(1, 1);

        public override int GetHashCode()
        {
            return HashCode.Combine(x, y);
        }

        public override bool Equals(object obj)
        {
            return obj is IntVector2 v && v.x == x && v.y == y;
        }

        // ----------
        // Operators

        public static bool operator ==(IntVector2 left, IntVector2 right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(IntVector2 left, IntVector2 right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            sb.Append("IntVector2(" + x + ", " + y + ")");

            return sb.ToString();
        }
    }

    /// <summary>
    /// Represents a Vector with 3 dimentions: x, y and z.<br></br>
    /// Basic comparision operations can be performed, such as == and !=
    /// </summary>
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

        /// <summary>Represents the Zero Vector3: (0, 0, 0)</summary>
        public static IntVector3 Zero() => new IntVector3(0, 0, 0);

        /// <summary>Represents the Identity Vector3: (1, 1, 1)</summary>
        //public static IntVector3 Identity() => new IntVector3(1, 1, 1);

        public override int GetHashCode()
        {
            return HashCode.Combine(x, y, z);
        }

        public override bool Equals(object obj)
        {
            return obj is IntVector3 v && v.x == x && v.y == y && v.z == z;
        }

        // ----------
        // Operators

        public static bool operator ==(IntVector3 left, IntVector3 right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(IntVector3 left, IntVector3 right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("IntVector3(" + x + ", " + y + ", " + z + ")");

            return sb.ToString();
        }
    }

    /// <summary>
    /// Represents a 2D Transform
    /// </summary>
    public struct IsoTransform2
    {
        public Vector2 position;

        /// <summary>
        /// rotation in degrees, not radiants
        /// </summary>
        public float rotation;
        public Vector2 scale;

        public IsoTransform2(Vector2 position, float rotation, Vector2 scale)
        {
            this.position = position;
            this.rotation = rotation;
            this.scale = scale;
        }

        public static IsoTransform2 Identity = new IsoTransform2();

        public static bool operator ==(IsoTransform2 lvalue, IsoTransform2 rvalue)
        {
            return lvalue.position == rvalue.position && lvalue.rotation == rvalue.rotation && lvalue.scale == rvalue.scale;
        }

        public static bool operator !=(IsoTransform2 lvalue, IsoTransform2 rvalue)
        {
            return !(lvalue == rvalue);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(position.X, position.Y, rotation, scale.X, scale.Y);
        }

        public override bool Equals(object obj)
        {
            return this == (IsoTransform2)obj;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("IsoTransform2: Position: " + position);
            sb.AppendLine("IsoTransform2: Rotation: " + rotation);
            sb.AppendLine("IsoTransform2: Scale   : " + scale);

            return sb.ToString();
        }
    }

    /// <summary>
    /// Represents a 3D Transform
    /// </summary>
    public struct IsoTransform3
    {
        public Vector3 position;

        /// <summary>
        /// rotation in degrees, not radiants
        /// </summary>
        public float rotation;
        public Vector3 scale;

        public IsoTransform3(Vector3 position, float rotation, Vector3 scale)
        {
            this.position = position;
            this.rotation = rotation;
            this.scale = scale;
        }

        public IsoTransform3(float x = 0, float y = 0, float z = 0, float rotation = 0, float sx = 1, float sy = 1, float sz = 1)
        {
            this.position = new(x, y, z);
            this.rotation = rotation;
            this.scale = new(sx, sy, sz);
        }

        public static IsoTransform3 Identity = new IsoTransform3(0, 0, 0, 0, 1, 1, 1);

        public static bool operator ==(IsoTransform3 lvalue, IsoTransform3 rvalue)
        {
            return lvalue.position == rvalue.position && lvalue.rotation == rvalue.rotation && lvalue.scale == rvalue.scale;
        }

        public static bool operator !=(IsoTransform3 lvalue, IsoTransform3 rvalue)
        {
            return !(lvalue == rvalue);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(position.X, position.Y, position.Z, rotation, scale.X, scale.Y, scale.Z);
        }

        public override bool Equals(object obj)
        {
            return this == (IsoTransform3)obj;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("IsoTransform3: Position: " + position);
            sb.AppendLine("IsoTransform3: Rotation: " + rotation);
            sb.AppendLine("IsoTransform3: Scale   : " + scale);

            return sb.ToString();
        }
    }
}
