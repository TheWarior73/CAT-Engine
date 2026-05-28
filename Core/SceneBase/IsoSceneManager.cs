using CAT_Engine.Core.Debug;
using CAT_Engine.Core.Rendering;
using CAT_Engine.Core.Rendering.Interfaces;
using System;

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

        /// <summary>
        /// Current Render Interface, reason we are using the interface is because the Scene Manager should not care if this is 
        /// IsoRenderer or IsoDebugRenderer or IsoVulkanRenderer or anything. It just needs to know "this has a render function"
        /// </summary>
        internal static IsoRenderInterface activeRenderer { get; private set; } = null;

        internal static void PreInit()
        {
            activeRenderer = new IsoRenderer();
        }

        public static T LoadScene<T>() where T : IsoScene
        {
            if (activeScene != null)
            {
                activeScene.Unload();
                activeScene = null;
            }

            T sceneInstance = Activator.CreateInstance<T>();
            sceneInstance.Load();

            activeScene = sceneInstance;

            return sceneInstance;
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
                .Build();

            activeRenderer.Render(context);
        }
    }
}