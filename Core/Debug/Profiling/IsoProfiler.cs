using System;
using System.Collections.Generic;

namespace CAT_Engine.Core.Debug.Profiling
{
    /// <summary>
    /// Holds profiling data for a named stat
    /// </summary>
    public class IsoProfileStat
    {
        /// <summary>
        /// Number of calls
        /// </summary>
        public int calls;

        /// <summary>
        /// Elapsed time
        /// </summary>
        public TimeSpan totalTime;
    }

    /// <summary>
    /// Static profiler that accumulates timing data from <see cref="IsoScopeCycleStat"/> instances.
    /// Call <see cref="Dump"/> to print all recorded stats.
    /// </summary>
    public static class IsoProfiler
    {
        private static Dictionary<string, IsoProfileStat> stats = new();

        /// <summary>
        /// Records a new entry that associates a name with an elapsed time.
        /// </summary>
        /// <param name="name">The name of the stat to record</param>
        /// <param name="elapsed">The elapsed time to add.</param>
        public static void Record(string name, TimeSpan elapsed)
        {
            if (!stats.TryGetValue(name, out IsoProfileStat stat))
            {
                stat = new IsoProfileStat();
                stats[name] = stat;
            }

            stat.calls++;
            stat.totalTime = elapsed;
        }

        /// <summary>
        /// Dumps the profiler and logs it's stats
        /// </summary>
        public static void Dump()
        {
            if (stats.Count == 0) return;

            foreach (var pair in stats)
            {
                IsoLogger.Log("{0}: {1} calls, {2}ms total", IsoLogger.ELogVerbosity.Log, pair.Key, pair.Value.calls, pair.Value.totalTime.TotalMilliseconds);
            }
        }

        /// <summary>
        /// Clears all stored stats.
        /// </summary>
        public static void Reset()
        {
            stats.Clear();
        }
    }
}
