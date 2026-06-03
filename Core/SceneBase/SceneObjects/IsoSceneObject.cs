using CAT_Engine.Core.Debug;
using CAT_Engine.Core.Interfaces;
using CAT_Engine.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.SceneBase.SceneObjects
{
    public class IsoSceneObject : IDisposable, IsoUpdateableInterface
    {
        public IsoTransform3 transform = IsoTransform3.Identity;
        public IsoScene scene { get; internal set; }

        protected internal virtual void OnAddedToScene(IsoScene scene) { }
        protected internal virtual void OnRemovedFromScene(IsoScene scene) { }

        /// <summary>
        /// Destroys the object and removes it from the scene.
        /// </summary>
        public void Destroy()
        {
            Dispose();
            scene.UnregisterObject(this);
        }

        /// <summary>
        /// Override to dispose any unmanaged resources, (Textures, RenderTarget's, etc...)
        /// </summary>
        public virtual void Dispose()
        {
            return;
        }

        public virtual void Update(float delta)
        {
            
        }
    }
}
