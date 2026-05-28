using CAT_Engine.Core.Rendering.Sprites;
using CAT_Engine.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAT_Engine.Core.Rendering.Interfaces.Renderables
{
    public interface IsoSpriteRenderableInterface : IsoRenderableInterface
    {
        IsoTransform2 transform { get; }
        IsoSprite sprite { get; }
    }
}
