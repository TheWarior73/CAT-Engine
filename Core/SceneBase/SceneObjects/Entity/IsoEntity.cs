using CAT_Engine.Core.Debug;
using CAT_Engine.Core.Rendering;
using CAT_Engine.Core.Rendering.Enumerators;
using CAT_Engine.Core.Rendering.Interfaces.Renderables;
using CAT_Engine.Core.Rendering.Sprites;
using CAT_Engine.Core.Rendering.Utility;
using CAT_Engine.Core.SceneBase;
using CAT_Engine.Core.Utility;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.SceneBase.SceneObjects.Entity
{
    public class IsoEntity : IsoSceneObject, IsoRenderableObjectInterface
    {
        public IsoEntity()
        {
            transform.scale = new Vector3(64, 64, 64);
        }

        public IsoSprite sprite = new IsoSprite();

        public bool visible => true;

        public EIsoRenderLayer renderLayer => EIsoRenderLayer.Entities;

        public int sortOrder => (int)transform.position.X + (int)transform.position.Y + (int)transform.position.Z;

        public void Initialize(IsoScene scene)
        {
            sprite.SetTextureFromAsset("entities/entity");
        }

        public override void Dispose()
        {
            base.Dispose();
            sprite.Dispose();
        }

        public void Draw(IsoRenderContext ctx)
        {
            Rectangle entityRect = RenderUtility.IsoTransformToScreenRect(transform);
            sprite.Draw(ctx, entityRect);
        }

        public override void Update(float delta)
        {
            transform.position.X += delta / 100.0f;

            
            //IsoLogger.Log(transform.ToString());
        }
    }
}
