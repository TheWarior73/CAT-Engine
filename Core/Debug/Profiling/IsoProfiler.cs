using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Debug.Profiling
{
    /// <summary>
    /// Holds profiling data for a named stat
    /// </summary>
    public class IsoProfileStat
    {
        public int calls;
        public TimeSpan totalTime;
    }

    /// <summary>
    /// Static profiler that accumulates timing data from <see cref="IsoScopeStat"/> instances.
    /// Call <see cref="Dump"/> to print all recorded stats.
    /// <param name="name">The name of the stat to record</param>
    /// <param name="name">The elapsed time to add.</param>
    /// </summary>
    public static class IsoProfiler
    {
        private static Dictionary<string, IsoProfileStat> stats = new();

        public static void Record(string name, TimeSpan elapsed)
        {
            if(!stats.TryGetValue(name, out IsoProfileStat stat))
            {
                stat = new IsoProfileStat();
                stats[name] = stat;
            }

            stat.calls++;
            stat.totalTime = elapsed;
        }

        public static void Dump()
        {
            if (stats.Count == 0) return;

            foreach(var pair in stats)
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
