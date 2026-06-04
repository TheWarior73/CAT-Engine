using CAT_Engine.Core.Debug;
using CAT_Engine.Core.Rendering.Interfaces;
using CAT_Engine.Core.Rendering.Interfaces.Renderables;
using Microsoft.Xna.Framework;
using SharpDX.DXGI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CAT_Engine.Core.Rendering
{
    public class IsoRenderer : IsoRendererInterface
    {
        public IsoRenderer(GameWindow inWindow) 
        {
            window = inWindow;

            window.ClientSizeChanged += OnWindowSizeChanged;
            OnWindowSizeChanged(window, new EventArgs());
        }

        private void OnWindowSizeChanged(object sender, System.EventArgs e)
        {
            DPIScale = Math.Min(window.ClientBounds.Width / 1920.0f, window.ClientBounds.Height / 720.0f);
            IsoLogger.Log("NEW DPI SCALE AFTER WINDOW RESIZE: {0}", IsoLogger.ELogVerbosity.Log, DPIScale);
        }

        public GameWindow window { get; set; }
        public static float DPIScale { get; private set; } = 1.0f;

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
