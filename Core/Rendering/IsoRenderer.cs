using CAT_Engine.Core.SceneBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Rendering
{
    public class IsoRenderer
    {
        public IsoRenderer() { }
        public IsoRenderContext RenderContext { get; set; }
        public void RenderScene(IsoScene scene) 
        {
            SetupRenderContext();
            
        }

        public void SetupRenderContext()
        {
            IsoRenderContextBuilder builder = new IsoRenderContextBuilder();
            builder.SetCamera(IsoSceneManager.activeCamera);

            RenderContext = builder.Build();
        }
    }
}
