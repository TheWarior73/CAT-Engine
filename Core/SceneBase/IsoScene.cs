using CAT_Engine.Core.Interfaces;
using CAT_Engine.Core.Rendering.Interfaces.Renderables;
using CAT_Engine.Core.SceneBase.SceneObjects;
using CAT_Engine.Core.SceneBase.SceneObjects.Entity;
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
    public abstract class IsoScene : IsoUpdateableInterface
    {
        //Only the engine can create scenes directly
        public class SceneToken
        {
            private SceneToken() { }
            internal static readonly SceneToken Instance = new SceneToken();
        }

        protected IsoScene(SceneToken token) { }

        private List<IsoRenderableObjectInterface> renderableObjects = new();

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

        protected void AddRenderableObject(IsoRenderableObjectInterface newRenderable)
        {
            renderableObjects.Add(newRenderable);
        }

        protected void RemoveRenderableObject(IsoRenderableObjectInterface renderable)
        {
            renderableObjects.Remove(renderable);
        }

        public virtual List<IsoRenderableObjectInterface> GetRenderableObjects()
        {
            return renderableObjects;
        }

        //Spawners

        /// <summary>
        /// Spawns an Entity of type and adds it to the scene <see cref="T"/>
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

        public virtual void Update(float delta)
        {
            for (int i = 0; i < sceneObjects.Count; i++)
            {
                sceneObjects[i].Update(delta);
            }
        }
    }
}
