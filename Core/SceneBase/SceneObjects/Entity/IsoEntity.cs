using CAT_Engine.Core.Rendering;
using CAT_Engine.Core.Rendering.Enumerators;
using CAT_Engine.Core.Rendering.Interfaces.Renderables;
using CAT_Engine.Core.Rendering.Sprites;
using CAT_Engine.Core.Rendering.Utility;
using Microsoft.Xna.Framework;

namespace CAT_Engine.Core.SceneBase.SceneObjects.Entity
{
    /// <summary>
    /// Represents an isometric entity. Public members :<br/>
    /// <see cref="sprite"/><br/>
    /// <see cref="visible"/><br/>
    /// <see cref="renderLayer"/><br/>
    /// <see cref="sortOrder"/><br/>
    /// <see cref="Initialize(IsoScene)"/><br/>
    /// <see cref="Dispose"/><br/>
    /// <see cref="Draw"/><br/>
    /// <see cref="Update(float)"/>
    /// </summary>
    public class IsoEntity : IsoSceneObject, IsoRenderableObjectInterface
    {
        /// <summary>
        /// Default constructor<br/>
        /// The resulting <see cref="Vector3"/> is set to (64, 64, 64)
        /// </summary>
        public IsoEntity()
        {
            transform.scale = new Vector3(64, 64, 64);
        }

        /// <summary>
        /// The sprite associated with the entity
        /// </summary>
        public IsoSprite sprite = new IsoSprite();

        /// <summary>
        /// Wether the entity is visible or not
        /// </summary>
        public bool visible => true;

        /// <summary>
        /// The render layer
        /// </summary>
        public EIsoRenderLayer renderLayer => EIsoRenderLayer.Entities;

        /// <summary>
        /// The sort order
        /// </summary>
        public int sortOrder => (int)transform.position.X + (int)transform.position.Y + (int)transform.position.Z;

        /// <summary>
        /// Initialisation of the entity
        /// </summary>
        /// <param name="scene">The associated scene</param>
        public void Initialize(IsoScene scene)
        {
            sprite.SetTextureFromAsset("entities/entity");
        }

        /// <summary>
        /// Disposes of the entity and it's sprite
        /// </summary>
        public override void Dispose()
        {
            base.Dispose();
            sprite.Dispose();
        }

        /// <summary>
        /// Draws the entity on the screen
        /// </summary>
        /// <param name="ctx"></param>
        public void Draw(IsoRenderContext ctx)
        {
            Rectangle entityRect = RenderUtility.IsoTransformToScreenRect(transform);
            sprite.Draw(ctx, entityRect);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="delta"><inheritdoc/></param>
        public override void Update(float delta)
        {
            transform.position.X += delta / 100.0f;


            //IsoLogger.Log(transform.ToString());
        }
    }
}
