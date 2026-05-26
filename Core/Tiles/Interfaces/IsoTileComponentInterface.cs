using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Tiles.Interfaces
{
    /// <summary>
    /// Interface that include anything that every TileComponent needs
    /// </summary>
    public interface IsoTileComponentInterface
    {
        
    }

    /// <summary>
    /// Interface for the <see cref="IsoRenderableTileComponent"/>
    /// </summary>
    public interface IsoRenderableTileComponentInterface
    {
        /// <summary>
        /// Should retrieve the texture of the current tile component
        /// </summary>
        /// <returns>The current tile component's texture</returns>
        public string GetTextureID();
    }
}
