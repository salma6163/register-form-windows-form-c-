using System.IO;
namespace task1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        //    FileStream fs = new FileStream("OS first task.txt",FileMode.Create,FileAccess.Write);
            
        }
    }
}