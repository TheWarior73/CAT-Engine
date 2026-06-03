using CAT_Engine.Core.Assets;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Rendering.Sprites
{
    public class IsoSprite : IDisposable
    {
        public Texture2D texture { get; set; }

        public Rectangle? sourceRectangle { get; set; }

        public Vector2 origin { get; set; } = Vector2.Zero;

        public Color color { get; set; } = Color.White;

        public SpriteEffects effects { get; set; } = SpriteEffects.None;

        public float opacity { get; set; } = 1f;

        public void SetTextureFromAsset(string assetPath)
        {
            texture = IsoGame.assetManager.LoadAsset<Texture2D>(assetPath);
        }

        public void Draw(IsoRenderContext ctx, Rectangle destinationRectangle)
        {
            if (texture == null) return;

            ctx.spriteBatch.Draw(
                texture,
                destinationRectangle,
                sourceRectangle,
                color * opacity,
                0f,
                origin,
                effects,
                0f
            );
        }

        public virtual void Dispose()
        {
            texture.Dispose();
        }
    }
}
