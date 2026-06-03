using CAT_Engine.Core.Rendering.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Rendering.Interfaces.Renderables
{
    public interface IsoRenderableObjectInterface
    {
        bool visible { get; }
        EIsoRenderLayer renderLayer { get; }
        int sortOrder { get; }
        void Draw(IsoRenderContext ctx);
    }
}
