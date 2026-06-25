using CAT_Engine.Core.Debug;
using CAT_Engine.Core.SceneBase;
using CAT_Engine.Core.SceneBase.SceneObjects.Entity;
using CAT_Engine.Core.Tiles;
using CAT_Engine.Core.Tiles.TileObjects;
using CAT_Engine.Core.Utility;

namespace CATSandboxGame.Scenes
{
    public class GameScene : IsoScene
    {
        public IsoTilemap tilemap = new IsoTilemap();

        public GameScene(SceneToken token) : base(token)
        {
        }

        public override void BeginPlay()
        {
            //TestMap();
            TestEntity();
        }

        private void TestMap()
        {
            using var _ = new IsoScopeCycleStat("GameScene.TestMap");

            // Create a tile object
            // Add this object to 0,0,0
            // Add another object to 0,0,1
            // Add another object to 0,0,1
            // Add another object to 100,100,0
            // *Map should have 2 chunks, 3 Zlayers, 3 Squares, 4 Objects

            IsoTileObject obj1 = new IsoTileObject();
            obj1.id = "objectOne";

            IsoTileObject obj2 = new IsoTileObject();
            obj2.id = "objectTwo";

            IsoTileObject obj3 = new IsoTileObject();
            obj3.id = "objectThree";

            IsoTileObject obj4 = new IsoTileObject();
            obj4.id = "objectFour";

            tilemap.AddObject(obj1, new IntVector3(0, 0, 0));
            tilemap.AddObject(obj2, new IntVector3(0, 0, 1));
            tilemap.AddObject(obj3, new IntVector3(0, 0, 1));
            tilemap.AddObject(obj4, new IntVector3(100, 100, 0));

            IsoLogger.Log("Tilemap after addition:\n{0}", tilemap.ToString());

            // Remove the 0,0,0 obj
            // Remove the other 0,0,0 obj
            // Remove the 0,0,1 obj
            // Remove the 100,100,0 obj
            // *map should be empty*
            tilemap.RemoveObject(obj1, new IntVector3(0, 0, 0));
            tilemap.RemoveObject(obj2, new IntVector3(0, 0, 1));
            tilemap.RemoveObject(obj3, new IntVector3(0, 0, 1));
            tilemap.RemoveObject(obj4, new IntVector3(100, 100, 0));

            IsoLogger.Log("Tilemap after removal:\n{0}", tilemap.ToString());
        }

        private void TestEntity()
        {
            using var _ = new IsoScopeCycleStat("GameScene.TestEntity");

            IsoEntity e = SpawnEntity<IsoEntity>();
            e.sprite.SetTextureFromAsset("entities/entity");
        }
    }
}
