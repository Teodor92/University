namespace SimpleBookStore.Web
{
    using System;
    using System.Data.Entity;
    using System.Web;
    using System.Web.Optimization;
    using System.Web.Routing;

    using SimpleBookStore.Data;
    using SimpleBookStore.Data.Migrations;

    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SbsDbContext, DefaultMigrationConfiguration>());

            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}