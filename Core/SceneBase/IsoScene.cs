using CAT_Engine.Core.Rendering.Interfaces.Renderables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.SceneBase
{
    /**
     * Isometric Scene to represent almost anything in a game
     */ 
    public class IsoScene
    {
        public IsoScene() { }

        private List<IsoRenderableInterface> renderableObjects = new();

        public virtual void Load() { }
        public virtual void Unload() { }

        public void AddRenderableObject(IsoRenderableInterface newRenderable)
        {
            renderableObjects.Add(newRenderable);
        }

        public virtual List<IsoRenderableInterface> GetRenderableObjects()
        {
            return renderableObjects;
        }
    }
}
