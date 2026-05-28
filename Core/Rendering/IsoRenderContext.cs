using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAT_Engine.Core.SceneBase;
using Microsoft.Xna.Framework.Graphics;

namespace CAT_Engine.Core.Rendering
{
    public class IsoRenderContext
    {
        public IsoCamera? camera;
        public IsoScene? scene;
        public SpriteBatch spriteBatch;
        public GraphicsDevice graphicsDevice;
        public Dictionary<string, object> extras { get; } = new();

        public T GetExtra<T>(string key)
        {
            extras.TryGetValue(key, out object? value);
            return (T)value;
        }
    }

    public class IsoRenderContextBuilder
    {
        IsoRenderContext renderContext;

        public IsoRenderContextBuilder()
        {
            renderContext = new IsoRenderContext();
        }

        public IsoRenderContextBuilder SetCamera(IsoCamera camera)
        {
            renderContext.camera = camera;
            return this;
        }

        public IsoRenderContextBuilder SetScene(IsoScene scene)
        {
            renderContext.scene = scene;
            return this;
        }

        public IsoRenderContextBuilder SetGraphicsDevice(GraphicsDevice gd)
        {
            renderContext.graphicsDevice = gd;
            return this;
        }

        public IsoRenderContextBuilder SetSpriteBatch(SpriteBatch sb)
        {
            renderContext.spriteBatch = sb;
            return this;
        }

        public IsoRenderContextBuilder AddExtra(string key, object? value)
        {
            renderContext.extras[key] = value;
            return this;
        }

        /**
         * Returns the render context
         */
        public IsoRenderContext Build()
        {
            return renderContext;
        }
    }
}
