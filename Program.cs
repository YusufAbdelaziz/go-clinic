
using goclinic.Models;

namespace goclinic
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            User.Instance.InitFromData("Yusuf", 3);
            Console.WriteLine(User.Instance.Name);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new AddPatient1());
        }
    }
}