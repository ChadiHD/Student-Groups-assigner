using StudentGroupsLibrary;
using System;
using System.Windows.Forms;

namespace CourseWork
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GlobalConfig.InitializeConnections(DataType.TextFile);
            
            Application.Run(new GroupViewerForm());
        }
    }
}
