namespace SiteUtilizandoAspNetMvc4.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SiteUtilizandoAspNetMvc4.Repository.DefaultDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SiteUtilizandoAspNetMvc4.Repository.DefaultDBContext";
        }

        protected override void Seed(SiteUtilizandoAspNetMvc4.Repository.DefaultDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
