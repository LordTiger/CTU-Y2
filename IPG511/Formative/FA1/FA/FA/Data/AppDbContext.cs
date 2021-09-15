//Brandon de Bruyn 6854
using FA.Models;
using System.Data.Entity;

namespace FA.Data
{
    public class AppDbContext :DbContext
    {

        public AppDbContext()
        { }

        public DbSet<Register> Register { get; set; }
        public DbSet<Home> Home { get; set; }
    }
}