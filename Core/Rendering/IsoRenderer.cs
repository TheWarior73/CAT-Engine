using CAT_Engine.Core.Rendering.Interfaces;
using CAT_Engine.Core.Rendering.Interfaces.Renderables;
using System.Collections.Generic;
using System.Linq;

namespace CAT_Engine.Core.Rendering
{
    public class IsoRenderer : IsoRendererInterface
    {
        public void Render(IsoRenderContext ctx)
        {
            if (ctx == null) return;
            if (ctx.scene == null) return;
            if (ctx.spriteBatch == null) return;

            List<IsoRenderableObjectInterface> sceneRenderableObjects = ctx.scene.GetRenderableObjects();

            if (sceneRenderableObjects == null || sceneRenderableObjects.Count == 0) return;

            IEnumerable<IsoRenderableObjectInterface> sortedRenderables = sceneRenderableObjects
                .Where(r => r.visible)
                .OrderBy(r => r.renderLayer)
                .ThenBy(r => r.sortOrder);

            ctx.spriteBatch.Begin();
            foreach (var renderable in sortedRenderables)
            {
                renderable.Draw(ctx);
            }
            ctx.spriteBatch.End();
        }
    }
}
