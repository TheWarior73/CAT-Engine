using CAT_Engine.Core.Debug;
using CAT_Engine.Core.Interfaces;
using CAT_Engine.Core.Utility;
using System;
using System.Runtime.CompilerServices;

namespace CAT_Engine.Core.SceneBase.SceneObjects
{
    /// <summary>
    /// Represents an Isometric Scene Object. The object can be detroyed, disposed off of and updated. The object has a <see cref="transform"/> and a <see cref="scene"/> associated to it.
    /// </summary>
    public class IsoSceneObject : IDisposable, IsoUpdateableInterface
    {
        /// <summary>
        /// The 3D transform associated with the object
        /// </summary>
        public IsoTransform3 transform = IsoTransform3.Identity;

        /// <summary>
        /// The scene associated with the object
        /// </summary>
        public IsoScene scene { get; internal set; }

        /// <summary>
        /// Called when the object is added to a scene
        /// </summary>
        /// <param name="scene">The scene the object is being added to</param>
        protected internal virtual void OnAddedToScene(IsoScene scene) { }

        /// <summary>
        /// Called when the object is removed from a scene
        /// </summary>
        /// <param name="scene">The scene from wich the object is being removed</param>
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

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="delta"><inheritdoc/></param>
        public virtual void Update(float delta)
        {
            IsoLogger.Log($"[{new CallerMemberNameAttribute()}] NotImplemented", IsoLogger.ELogVerbosity.Warning);
        }
    }
}
