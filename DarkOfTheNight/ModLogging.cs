// Jake Huxell 2018

using StardewModdingAPI;

namespace DarkOfTheNight
{
    internal static class ModLogging
    {
        private static IMonitor CurrentLog;

        public static void SetLogger(IMonitor inLogger)
        {
            CurrentLog = inLogger;
        }

        public static void Log(string inText)
        {
            #if DEBUG
                CurrentLog.Log(inText);
            #endif
        }
    }
}
