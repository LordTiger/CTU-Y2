namespace Practical_1_May_12.Migrations
{
    using Practical_1_May_12.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Practical_1_May_12.Data_Folder.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Practical_1_May_12.Data_Folder.AppDbContext context)
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

            context.Products.AddOrUpdate(
                p => p.ProductName,                                    
                new Product { ProductName = "Computer Graphics Card", Description = "Expensive Graphics Card", Price = 15000M },
                new Product { ProductName = "Computer Motherboard", Description = "Expensive Motherboard", Price = 5000M },   
                new Product { ProductName = "Computer RAM", Description = "Expensive Ram", Price = 3000M });
        }
    }
}
