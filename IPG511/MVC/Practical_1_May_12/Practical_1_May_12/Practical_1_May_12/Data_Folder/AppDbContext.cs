using Practical_1_May_12.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Practical_1_May_12.Data_Folder
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Shelfs> Shelfs { get; set; }
    }
}