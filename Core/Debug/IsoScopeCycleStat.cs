using CAT_Engine.Core.Debug.Profiling;
using System;
using System.Diagnostics;

namespace CAT_Engine.Core.Debug
{
    /// <summary>
    /// A disposable struct that times a scope and reports it to <see cref="IsoProfiler"/>
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

        /// <summary>
        /// Number of calls done during a cycle.
        /// </summary>
        public int calls = 0;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">The cycle name</param>
        public IsoScopeCycleStat(string name)
        {
            this.name = name;
            start = Stopwatch.GetTimestamp();
        }

        /// <summary>
        /// Stops the timer and records the elapsed time.
        /// </summary>
        public void Dispose()
        {
            TimeSpan elapsed = Stopwatch.GetElapsedTime(start);
            IsoProfiler.Record(name, elapsed);
        }
    }
}
