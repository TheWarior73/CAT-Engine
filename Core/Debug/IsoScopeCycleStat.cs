using CAT_Engine.Core.Debug.Profiling;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Debug
{
    /// <summary>
    /// A disposable struct that times a scope and reports it to <see cref="Profiler"/>
    /// Use with a <c>using</c> statement to automatically record elapsed time on scope exit
    /// <example>
    /// <code>
    /// using var _ = new ScopeStat("Class.Method");
    /// </code>
    /// </example>
    /// </summary>
    public struct IsoScopeCycleStat : IDisposable
    {
        private readonly string name;
        private readonly long start;
        public int calls = 0;

        public IsoScopeCycleStat(string name)
        {
            this.name = name;
            start = Stopwatch.GetTimestamp();
        }

        public void Dispose()
        {
            TimeSpan elapsed = Stopwatch.GetElapsedTime(start);
            IsoProfiler.Record(name, elapsed);
        }
    }
}
