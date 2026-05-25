using CAT_Engine.Core.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.SceneBase
{
    /**
     * Isometric Scene Manager, 
     * chooses which scene to render, which camera to use...
     */
    public static class IsoSceneManager
    {
        public static IsoScene activeScene = null;
        public static IsoCamera activeCamera = null;
        public static IsoRenderer activeRenderer = new();

        public static T LoadScene<T>() where T : IsoScene
        {
            if(activeScene != null)
            {
                activeScene.Unload();
                activeScene = null;
            }

            T sceneInstance = (T)(Activator.CreateInstance(typeof(T)));
            sceneInstance.Load();

            activeScene = sceneInstance;

            return sceneInstance;
        }

        public static void Init()
        {
            
        }
    }
}
