using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Debug
{
    public static class IsoLogger
    {
        public static ELogVerbosity currentVerbosity = ELogVerbosity.VeryVerbose;

        public enum ELogVerbosity
        {
            Fatal,
            Error,
            Warning,
            Log,
            Display,
            Verbose,
            VeryVerbose
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
            if (currentVerbosity <= verbosity) return;

            string verbosityString = string.Format("[{0}]: ", verbosity.ToString());
            string formattedString = string.Format(format, args);
            string logString = verbosityString + formattedString;

            System.Diagnostics.Debug.Assert(verbosity != ELogVerbosity.Fatal);
            System.Diagnostics.Debug.WriteLine(logString);

            //@TODO: in release and debug later, write log to file.
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

            System.Diagnostics.Debug.WriteLine(logString);

            throw new Exception(logString);
        }
    }
}
