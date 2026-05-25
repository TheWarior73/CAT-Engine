using CAT_Engine.Core.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.SceneBase
{
    public class IsoSceneManager
    {
        public IsoSceneManager() { }

        public IsoScene currentScene = null;
        public IsoCamera activeCamera = null;

        public T LoadScene<T>() where T : IsoScene
        {
            if(currentScene != null)
            {
                currentScene.Unload();
                currentScene = null;
            }

            T sceneInstance = (T)(Activator.CreateInstance(typeof(T)));
            sceneInstance.Load();

            currentScene = sceneInstance;

            return sceneInstance;
        }

        public void Init()
        {
            
        }
    }
}
