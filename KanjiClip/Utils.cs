using System.Diagnostics;

namespace KanjiClip
{
    internal class Utils
    {
        public static bool IsAnkiRunning()
        {
            return Process.GetProcessesByName("anki").Length > 0;
        }
    }
}
