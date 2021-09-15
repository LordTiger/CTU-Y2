using Example1.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Example1.Data
{
    public class stDataContext : DbContext
    {
        public stDataContext()
        { }
       public DbSet<Student> Students { get; set; }
    }
}