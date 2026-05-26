using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CAT_Engine.Core.Debug
{
    public static class IsoLogger
    {
        public static ELogVerbosity currentVerbosity = ELogVerbosity.VeryVerbose;

        public enum ELogVerbosity
        {
            /// <summary>Always prints and triggers a debug assertion. Use for unrecoverable errors.</summary>
            Fatal,
            /// <summary>Something went wrong but the game can continue. Use for missing assets, bad state etc.</summary>
            Error,
            /// <summary>Something unexpected happened but it's not breaking. Use for fallbacks and edge cases.</summary>
            Warning,
            /// <summary>General info about what the engine is doing. Use for system events like init, shutdown.</summary>
            Log,
            /// <summary>Info intended to be seen during normal play. Use for game events like level load, player actions.</summary>
            Display,
            /// <summary>Detailed info for debugging specific systems. Noisy, disable unless investigating.</summary>
            Verbose,
            /// <summary>Extremely detailed, per-frame level info. Only enable when hunting a VERY specific bug.</summary>
            VeryVerbose
        }

        public static void SetVerbosity(ELogVerbosity newVerbosity)
        {
            currentVerbosity = newVerbosity;
        }

        /// <summary>
        /// Logs to the logger in debug builds and in release will log to a log file.
        /// </summary>
        /// <param name="format">Format of the message</param>
        /// <param name="verbosity">Verbosity, will not show up if <see cref="currentVerbosity"/> is at a lower level than the input verbosity</param>
        /// <param name="args"></param>

        [Conditional("DEBUG")]
        public static void Log(string format, ELogVerbosity verbosity = ELogVerbosity.Display, params object?[]? args)
        {
            if (verbosity > currentVerbosity) return;

            string verbosityString = string.Format("[{0}]: ", verbosity.ToString());
            string formattedString = string.Format(format, args);
            string logString = verbosityString + formattedString;

            System.Diagnostics.Debug.Assert(verbosity != ELogVerbosity.Fatal);
            SimpleWriteLine(logString);

            //@TODO: in release and debug later, write log to file.
        }

        /// <summary>
        /// <inheritdoc cref="Log(string, ELogVerbosity, object?[]?)"/>
        /// </summary>
        [Conditional("DEBUG")]
        public static void Log(string format, params object?[]? args)
        {
            Log(format, ELogVerbosity.Display, args);
        }

        /// <summary>
        /// Checks for a condition, if the condition is <see cref="false"/> then it will output the message and show a message box with the call stack.
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void Assert(bool condition, string format, params object?[]? args)
        {
            System.Diagnostics.Debug.Assert(condition, string.Format(format, args));
        }

        /// <summary>
        /// Logs with no verbosity and throws an exception.
        /// Stripped in non-debug builds
        /// </summary>
        /// <param name="format">Format for message</param>
        /// <param name="args">message objects</param>
        /// <exception cref="Exception">throws an exception with the formatted message</exception>

        [Conditional("DEBUG")]
        public static void Except(string format, params object?[]? args)
        {
            string verbosityString = "[EXCEPTION]: ";
            string formattedString = string.Format(format, args);
            string logString = verbosityString + formattedString;

            SimpleWriteLine(logString);

            throw new Exception(logString);
        }

        private static void SimpleWriteLine(string message)
        {
            //System.Diagnostics.Debug.WriteLine(message);
            System.Diagnostics.Trace.WriteLine(message);
        }
    }
}
