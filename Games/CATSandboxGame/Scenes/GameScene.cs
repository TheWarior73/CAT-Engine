using CAT_Engine.Core.SceneBase;
using CAT_Engine.Core.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATSandboxGame.Scenes
{
    public class GameScene : IsoScene
    {
        public GameScene() { }

        public IsoTilemap tilemap = new IsoTilemap();
    }
}
