using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Tiles.TileComponents
{
    /// <summary>
    /// Base Class for tile components, will define Tile Object State, Behaviour and Visual
    /// </summary>
    public abstract class IsoTileComponent {
        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine("Component");

            return sb.ToString();
        }
    }
}
