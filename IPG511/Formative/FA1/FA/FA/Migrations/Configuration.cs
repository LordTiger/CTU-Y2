namespace FA.Migrations
{
    using FA.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FA.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FA.Data.AppDbContext context)
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

            context.Home.AddOrUpdate(
                p => p.FirstName,
                new Home
                {FirstName = "Brandon", LastName = "de Bruyn", Address1 = "N/A", EmailID = "6854@ctucareer.co.za"},
                new Home
                { FirstName = "Martin", LastName = "Bold", Address1 = "N/A", EmailID = "1002@ctucareer.co.za" },
                new Home
                { FirstName = "Isaac", LastName = "Nel", Address1 = "140 Smith Avenue Vereeniging", EmailID = "1001@ctucareer.co.za" },
                new Home
                { FirstName = "Jason", LastName = "Smith", Address1 = "45 Elgin Street Vanderbijpark", EmailID = "1003@ctucareer.co.za" },
                new Home
                { FirstName = "Micheal", LastName = "Brink", Address1 = "567 Ring Road Pretoria", EmailID = "2045@ctucareer.co.za" }
                );
        }
    }
}
