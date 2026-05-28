using CAT_Engine.Core.Debug;
using CAT_Engine.Core.Rendering.Interfaces;
using CAT_Engine.Core.Rendering.Interfaces.Renderables;
using CAT_Engine.Core.Rendering.SpecializedRenderers;
using CAT_Engine.Core.SceneBase;
using CAT_Engine.Core.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Rendering
{
    public class IsoRenderer : IsoRenderInterface
    {
        public IsoRenderer() { }

        public IsoTilemapRenderer tilemapRenderer { get; set; } = new();

        public IsoRenderContext GetRenderContext()
        {
            return new IsoRenderContextBuilder()
                .SetCamera(IsoSceneManager.activeCamera)
                .SetScene(IsoSceneManager.activeScene)
                .Build();
        }

        public void Render(IsoRenderContext ctx)
        {
            if (ctx == null) return;
            if (ctx.scene == null) return;

            List<IsoRenderableInterface> sceneRenderableObjects = ctx.scene.GetRenderableObjects();

            if (sceneRenderableObjects == null || sceneRenderableObjects.Count == 0) return;

            //sort them :3
            sceneRenderableObjects
                .Where(r => r.visible)
                .OrderBy(r => r.renderLayer)
                .ThenBy(r => r.sortOrder);

            foreach (IsoRenderableInterface renderable in sceneRenderableObjects)
            {
                DrawWorldRenderable(renderable, ctx);
            }
        }

        private void DrawWorldRenderable(IsoRenderableInterface r, IsoRenderContext ctx)
        {
            switch(r)
            {
                case IsoTilemap tilemap:
                    tilemapRenderer.Render(tilemap, ctx);
                    break;

                case IsoSpriteRenderableInterface spriteRenderable:
                    //TODO: add IsoSpriteRenderer.Render()
                    break;

                default:
                    IsoLogger.Log(
                        $"Unsupported renderable type: {r.GetType().Name}",
                        IsoLogger.ELogVerbosity.Warning
                    );
                    break;
            }
        }
    }
}
