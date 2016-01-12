namespace LewisList.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LewisList.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LewisList.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
         
            context.Categories.AddOrUpdate(x => x.CategoryId,
                new Category() { CategoryName = "Real Estate", CategoryMasterName = "For Sale" },
                new Category() { CategoryName = "Baby", CategoryMasterName = "For Sale" },
                new Category() { CategoryName = "Auto/Truck", CategoryMasterName = "For Sale" },
                new Category() { CategoryName = "Auto/Car", CategoryMasterName = "For Sale" },
                new Category() { CategoryName = "Auto Parts", CategoryMasterName = "For Sale" },
                new Category() { CategoryName = "Motorcycles", CategoryMasterName = "For Sale" },
                new Category() { CategoryName = "Furniture", CategoryMasterName = "For Sale" },
                new Category() { CategoryName = "Household", CategoryMasterName = "For Sale" },
                new Category() { CategoryName = "General Free", CategoryMasterName = "For Sale" },
                new Category() { CategoryName = "Computers", CategoryMasterName = "For Sale" },
                new Category() { CategoryName = "Electronics", CategoryMasterName = "For Sale" },
                new Category() { CategoryName = "Mobile Devices", CategoryMasterName = "For Sale" },
                new Category() { CategoryName = "Lost/Found", CategoryMasterName = "Pets" },
                new Category() { CategoryName = "Free ", CategoryMasterName = "Pets" },
                new Category() { CategoryName = "General Labor ", CategoryMasterName = "Jobs" },
                new Category() { CategoryName = "Sales ", CategoryMasterName = "Jobs" },
                new Category() { CategoryName = "Information Technology", CategoryMasterName = "Jobs" },
                new Category() { CategoryName = "Transport", CategoryMasterName = "Jobs" },
                new Category() { CategoryName = "Customer Service", CategoryMasterName = "Jobs" },
                new Category() { CategoryName = "General", CategoryMasterName = "Jobs" },
                new Category() { CategoryName = "Healthcare", CategoryMasterName = "Jobs" },
                new Category() { CategoryName = "Computer", CategoryMasterName = "Services" },
                new Category() { CategoryName = "Financial", CategoryMasterName = "Services" },
                new Category() { CategoryName = "Lawn Care", CategoryMasterName = "Services" },
                new Category() { CategoryName = "General Labor Services", CategoryMasterName = "Services" }


                );
                

        }
    }
}
