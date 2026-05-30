using CAT_Engine.Core.Rendering.Interfaces.Renderables;
using CAT_Engine.Core.Rendering.Sprites;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Rendering.SpecializedRenderers
{
    public class IsoSpriteRenderer
    {
        public IsoSpriteRenderer() { }

        //TODO: add sprite rendering logic
        public void RenderSprites(IsoRenderableObjectInterface r, IsoRenderContext ctx)
        {
            r.Draw(ctx);
        }
    }
}
