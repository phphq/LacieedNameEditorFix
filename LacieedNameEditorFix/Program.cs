using System;
using System.Reflection;
using System.Windows.Forms;

using LacieedNameEditorFix.Forms;

namespace LacieedNameEditorFix
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }

    public static class Config
    {
        public static bool ProgramDebug = false;

        public static string ProgramName = "lacieed Name Editor Fix";

        public static string ProgramVersion = Assembly.GetCallingAssembly().GetName().Version.Major + "." +
                                              Assembly.GetCallingAssembly().GetName().Version.Minor;

        public static string NoavHqUrl = "http://novahq.net/";
        public static string NoavHqUrlApp = NoavHqUrl + "?app=LacieedNameEditorFix" + ProgramVersion;

    }

}
