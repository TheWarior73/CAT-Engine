using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Rendering.Interfaces
{
    internal interface IsoRenderInterface
    {

        /**
         * Called when a object needs to be rendered
         */
        public void Render(IsoRenderContext ctx);
    }
}
