using CAT_Engine.Core.Interfaces;
using CAT_Engine.Core.Rendering.Interfaces.Renderables;
using CAT_Engine.Core.SceneBase.SceneObjects;
using CAT_Engine.Core.SceneBase.SceneObjects.Entity;
using System;
using System.Collections.Generic;

namespace CAT_Engine.Core.SceneBase
{
    /// <summary>
    /// Represents an Isometric Scene with objects, tiles, etc...
    /// </summary>
    public abstract class IsoScene : IsoUpdateableInterface
    {
        /// <summary>
        /// The engine is the only actor that can create Scenes, this token is there to handle Scene creation
        /// </summary>
        public class SceneToken
        {
            private SceneToken() { }
            internal static readonly SceneToken Instance = new SceneToken();
        }

        /// <summary>
        /// Creates an IsoScene from a <see cref="SceneToken"/>
        /// </summary>
        /// <param name="token">The token</param>
        protected IsoScene(SceneToken token) { }

        private List<IsoRenderableObjectInterface> renderableObjects = new();

        /// <summary>
        /// List of objects in the scene.
        /// </summary>
        protected List<IsoSceneObject> sceneObjects = new();

        internal virtual void Load()
        {
            BeginPlay();
        }
        internal virtual void Unload()
        {
            EndPlay();
        }

        public virtual void BeginPlay() { }
        public virtual void EndPlay() { }

        /// <summary>
        /// Adds a renderable Object to the <see cref="renderableObjects"/> list
        /// </summary>
        /// <param name="newRenderable">The renderable object</param>
        protected void AddRenderableObject(IsoRenderableObjectInterface newRenderable)
        {
            renderableObjects.Add(newRenderable);
        }

        /// <summary>
        /// Removes a renderable Object from the <see cref="renderableObjects"/> list
        /// </summary>
        /// <param name="renderable"></param>
        protected void RemoveRenderableObject(IsoRenderableObjectInterface renderable)
        {
            renderableObjects.Remove(renderable);
        }

        /// <summary>
        /// Provides the <see cref="renderableObjects"/> list
        /// </summary>
        /// <returns>The list</returns>
        public virtual List<IsoRenderableObjectInterface> GetRenderableObjects()
        {
            return renderableObjects;
        }

        //Spawners

        /// <summary>
        /// Spawns an Entity of type and adds it to the scene.
        /// </summary>
        /// <typeparam name="T">The Entity's Type</typeparam>
        /// <returns></returns>
        public T SpawnEntity<T>() where T : IsoEntity
        {
            T ent = (T)Activator.CreateInstance(typeof(T));
            ent.Initialize(this);

            RegisterObject(ent);
            return ent;
        }

        /// <summary>
        /// Registers a <see cref="IsoSceneObject"/> to the scene.
        /// <br></br>
        /// Will register the object to <see cref="sceneObjects"/> and <see cref="renderableObjects"/>
        /// </summary>
        /// <param name="o">Object to register</param>
        public void RegisterObject(IsoSceneObject o)
        {
            AddRenderableObject(o as IsoRenderableObjectInterface);
            AddSceneObject(o);
        }

        /// <summary>
        /// Unregisters a <see cref="IsoSceneObject"/> from the scene.
        /// <br></br>
        /// Will not remove it from memory if any reference is held to it.
        /// <br></br>
        /// For complete object destruction, see <see cref="IsoSceneObject.Destroy"/>
        /// <br></br>
        /// Will unregister the object from <see cref="sceneObjects"/> and <see cref="renderableObjects"/>
        /// </summary>
        /// <param name="o">Object to unregister.</param>
        public void UnregisterObject(IsoSceneObject o)
        {
            RemoveRenderableObject(o as IsoRenderableObjectInterface);
            RemoveSceneObject(o);
        }

        private void AddSceneObject(IsoSceneObject o)
        {
            sceneObjects.Add(o);
        }

        private void RemoveSceneObject(IsoSceneObject o)
        {
            sceneObjects.Remove(o);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="delta"><inheritdoc/></param>
        public virtual void Update(float delta)
        {
            for (int i = 0; i < sceneObjects.Count; i++)
            {
                sceneObjects[i].Update(delta);
            }
        }
    }
}
