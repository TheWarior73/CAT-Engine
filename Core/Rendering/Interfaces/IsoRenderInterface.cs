using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Rendering.Interfaces
{
    internal interface IsoRenderInterface
    {

        /// <summary>
        /// Called whenever something needs to be rendered.
        /// </summary>
        /// <param name="ctx">An Isometric Render Context</param>
        public void Render(IsoRenderContext ctx);
    }
}
