namespace Slms.Desktop
{
    using System;
    using System.Data.Entity;
    using System.Windows.Forms;

    using Slms.Data;
    using Slms.Data.Migrations;

    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            // Starts the automatic migrations
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SlmsDbContext, Configuration>());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
