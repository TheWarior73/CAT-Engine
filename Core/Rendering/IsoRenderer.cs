using CAT_Engine.Core.Rendering.Interfaces;
using CAT_Engine.Core.SceneBase;
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
        public IsoRenderContext RenderContext { get; set; }

        // Render Interface Implementation


        public IsoRenderContext GetRenderContext()
        {
            IsoRenderContextBuilder builder = new IsoRenderContextBuilder();
            builder.SetCamera(IsoSceneManager.activeCamera);
            builder.SetScene(IsoSceneManager.activeScene);

            return builder.Build();
        }

        public void Render(IsoRenderContext ctx)
        {
            throw new NotImplementedException();
        }
    }
}
