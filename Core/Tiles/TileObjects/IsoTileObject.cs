using CAT_Engine.Core.Tiles.Interfaces;
using CAT_Engine.Core.Tiles.TileComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Tiles.TileObjects
{
    /// <summary>
    /// Represents an Isometric Tile
    /// A Tile Object contains a list of <see cref="IsoTileComponent"/>'s
    /// </summary>
    public class IsoTileObject
    {
        public IsoTileObject() { }

        public IsoTileSquare parentSquare = null;
        public string id;
        public List<IsoTileComponent> components = new();

        /// <summary>
        /// Gets a component of a certain type attached to this <see cref="IsoTileObject"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetComponent<T>() where T : IsoTileComponent
        {
            return components.OfType<T>().FirstOrDefault();
        }

        /// <summary>
        /// Gets all components of a certain type attached to this <see cref="IsoTileObject"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public List<T> GetComponents<T>() where T : IsoTileComponent
        {
            return components.OfType<T>().ToList();
        }

        /// <summary>
        /// Called when this tile object gets added to a square. By default updates parent square
        /// </summary>
        /// <param name="square"></param>
        public virtual void OnAddedToSquare(IsoTileSquare square)
        {
            parentSquare = square;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("id: " + id);
            sb.AppendLine("Parent: " + parentSquare.GetType().ToString());

            sb.AppendLine("Components in square:");

            if (components.Count > 0)
            {
                foreach (IsoTileComponent component in components)
                {
                    string valueStr = component.ToString();
                    valueStr = valueStr.Replace("\n", "\n\t");

                    sb.Append(valueStr);
                }
            } 
            else
            {
                sb.Append("\tnull");
            }

            return sb.ToString();
        }
    }
}
