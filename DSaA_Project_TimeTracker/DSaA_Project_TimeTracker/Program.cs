using DSaA_Project_TimeTracker.Database;

namespace DSaA_Project_TimeTracker
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
            var seeder = new Seeder();
            seeder.Seed();
            Application.Run(new Form1());
        }
    }
}