using CAT_Engine.Core.Rendering.Enumerators;
using CAT_Engine.Core.Rendering.Interfaces.Renderables;
using CAT_Engine.Core.Rendering.Sprites;
using CAT_Engine.Core.SceneBase;
using CAT_Engine.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Entity
{
    public class IsoEntity : IsoRenderableInterface
    {
        public IsoEntity() { }

        public IsoTransform2 transform = IsoTransform2.Identity;
        public IsoSprite sprite = new IsoSprite();
        public IsoScene parentScene = null;

        public bool visible => true;

        public EIsoRenderLayer renderLayer => EIsoRenderLayer.Entities;

        public int sortOrder => 0;

        public void Initialize(IsoScene scene)
        {
            parentScene = scene;
            scene.AddRenderableObject(this);
            sprite.SetTextureFromAsset("entities/entity");
        }
    }
}
