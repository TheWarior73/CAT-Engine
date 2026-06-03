using CAT_Engine.Core.Debug;
using CAT_Engine.Core.Interfaces;
using CAT_Engine.Core.Rendering;
using CAT_Engine.Core.Rendering.Interfaces;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace CAT_Engine.Core.SceneBase
{
    /**
     * Isometric Scene Manager, 
     * chooses which scene to render, which camera to use...
     */
    public static class IsoSceneManager
    {
        public static IsoScene activeScene { get; private set; } = null;
        public static IsoCamera activeCamera { get; private set; } = null;
        internal static SpriteBatch spriteBatch { get; set; } = null;
        internal static GraphicsDevice graphicsDevice { get; set; } = null;
        public static List<IsoScene> scenes {  get; private set; } = new List<IsoScene>();

        /// <summary>
        /// Current Render Interface, reason we are using the interface is because the Scene Manager should not care if this is 
        /// IsoRenderer or IsoDebugRenderer or IsoVulkanRenderer or anything. It just needs to know "this has a render function"
        /// </summary>
        internal static IsoRendererInterface activeRenderer { get; private set; } = null;

        internal static void PreInit()
        {
            activeRenderer = new IsoRenderer();
        }

        /// <summary>
        /// Creates a scene but does not load it yet.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T CreateScene<T>() where T : IsoScene
        {
            //Only the engine can create scenes directly
            T newScene = Activator.CreateInstance(typeof(T), IsoScene.SceneToken.Instance) as T;
            AddScene(newScene);
            return (T)newScene;
        }

        private static void AddScene(IsoScene scene)
        {
            scenes.Add(scene);
        }

        public static T LoadScene<T>() where T : IsoScene
        {
            if (activeScene != null)
            {
                activeScene.Unload();
                activeScene = null;
            }

            T sceneInstance = CreateScene<T>();
            
            sceneInstance.Load();

            activeScene = sceneInstance;

            return sceneInstance;
        }

        public static void LoadScene(IsoScene scene)
        {
            if (activeScene != null)
            {
                activeScene.Unload();
                activeScene = null;
            }

            scene.Load();
            activeScene = scene;
        }

        public static void SetActiveCamera(IsoCamera camera)
        {
            activeCamera = camera;
        }

        public static void RenderActiveScene()
        {
            if (activeRenderer == null)
            {
                IsoLogger.Log(
                    "Cannot render active scene because active renderer is null!",
                    IsoLogger.ELogVerbosity.Warning
                );

                return;
            }

            IsoRenderContext context = new IsoRenderContextBuilder()
                .SetCamera(activeCamera)
                .SetScene(activeScene)
                .SetSpriteBatch(spriteBatch)
                .SetGraphicsDevice(graphicsDevice)
                .Build();

            activeRenderer.Render(context);
        }

        public static void Update(float delta)
        {
            if (activeScene == null) return;
            activeScene.Update(delta);
        }
    }
}