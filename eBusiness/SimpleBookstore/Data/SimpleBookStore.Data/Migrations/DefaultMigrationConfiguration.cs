namespace SimpleBookStore.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Microsoft.AspNet.Identity.EntityFramework;

    using OJS.Data;

    using SimpleBookStore.Common;

    public class DefaultMigrationConfiguration : DbMigrationsConfiguration<SbsDbContext>
    {
        public DefaultMigrationConfiguration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SbsDbContext context)
        {
            if (context.Roles.Any())
            {
                return;
            }

            this.SeedRoles(context);
        }

        protected void SeedRoles(SbsDbContext context)
        {
            foreach (var entity in context.Roles)
            {
                context.Roles.Remove(entity);
            }

            context.Roles.AddOrUpdate(new IdentityRole(GlobalConstants.AdministratorRoleName));
        }
    }
}
