namespace Summative.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Summative.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Summative.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Summative.Models.ApplicationDbContext context)
        {
            context.Topics.AddOrUpdate(s => s.TopicName,
                new Topic { TopicName = "Date Science" },
                new Topic { TopicName = "Education" },
                new Topic { TopicName = "Human-Computer Interaction" },
                new Topic { TopicName = "IOT (Internet of Things)" });


            RoleStore<IdentityRole> roleStore = new RoleStore<IdentityRole>(context);
            RoleManager<IdentityRole> roleManager = new RoleManager<IdentityRole>(roleStore);


            IdentityRole adminRole = new IdentityRole { Name = "Admin" }; // Admin Role
            IdentityRole authorRole = new IdentityRole { Name = "Author" }; // Author Role

            //Begin of Role Checking
            //checking if roles does not exist
            if (!roleManager.RoleExists(adminRole.Name))
                roleManager.Create(adminRole);

            if (!roleManager.RoleExists(authorRole.Name))
                roleManager.Create(authorRole);
            // End of Role Checking

            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);

            // Creating Admin
            ApplicationUser adminUser = new ApplicationUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com"
            };

            var results = userManager.Create(adminUser, "!Admin1");


            if (results.Succeeded)
                userManager.AddToRole(adminUser.Id, adminRole.Name);

            base.Seed(context);
        }
    }
}
