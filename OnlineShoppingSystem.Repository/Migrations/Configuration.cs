namespace OnlineShoppingSystem.Repository.Migrations
{   using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
   

    internal sealed class Configuration : DbMigrationsConfiguration<OnlineShoppingSystem.DAL.OnlineShoppingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "OnlineShoppingSystem.Models.OnlineShoppingContext";
        }

        protected override void Seed(OnlineShoppingSystem.DAL.OnlineShoppingContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
