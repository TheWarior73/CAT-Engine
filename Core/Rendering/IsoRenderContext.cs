using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Rendering
{
    public class IsoRenderContext
    {
        public IsoCamera? camera;
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

        public IsoRenderContextBuilder AddExtra(string key, object? value)
        {
            renderContext.extras[key] = value;
            return this;
        }

        public IsoRenderContext Build()
        {
            return renderContext;
        }
    }
}
