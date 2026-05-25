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

        public virtual void Load() { }
        public virtual void Unload() { }

    }
}
