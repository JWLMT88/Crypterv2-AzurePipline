using System.Diagnostics;
using LILO_Packager.v2.Shared;

namespace Crypterv2_DevTool
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        private static void InitializeApplication()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
        }

        [STAThread]
        static void Main()
        {
            InitializeApplication();
            
            ConsoleManager.Instance().WriteLineWithColor("Initializing C2DT.");
            ConsoleManager.Instance().WriteLineWithColor("Session Log Located: " + Logger.Instance.logFilePath);
            Application.Run(MainHost.GetInstance());
            Console.ReadKey();
        }
    }
}