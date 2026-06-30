using CAT_Engine.Core.Debug;
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
        /// <summary>
        /// The rendered scene
        /// </summary>
        public static IsoScene activeScene { get; private set; } = null;

        /// <summary>
        /// The camera used as viewpoint
        /// </summary>
        public static IsoCamera activeCamera { get; private set; } = null;

        internal static SpriteBatch spriteBatch { get; set; } = null;
        internal static GraphicsDevice graphicsDevice { get; set; } = null;

        /// <summary>
        /// List os scenes loaded into the manager.
        /// </summary>
        public static List<IsoScene> scenes { get; private set; } = new List<IsoScene>();

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

        /// <summary>
        /// Loads a scene as the active scene and unloads the currently active scene at the same time.
        /// </summary>
        /// <typeparam name="T">The scene to be loaded</typeparam>
        /// <returns>the active scene Instance</returns>
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

        /// <summary>
        /// Loads a scene as the active scene and unloads the currently active scene at the same time.
        /// </summary>
        /// <param name="scene">The scene to be loaded</param>
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

        /// <summary>
        /// Changes the active camera to the specified one
        /// </summary>
        /// <param name="camera">Camera to be set as active</param>
        public static void SetActiveCamera(IsoCamera camera)
        {
            activeCamera = camera;
        }

        /// <summary>
        /// Renders the <see cref="activeScene"/> to the screen
        /// </summary>
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

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="delta"><inheritdoc/></param>
        public static void Update(float delta)
        {
            if (activeScene == null) return;
            activeScene.Update(delta);
        }
    }
}