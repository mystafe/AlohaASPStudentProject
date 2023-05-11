using ASPPTraining1.Models.ORM;
using Microsoft.EntityFrameworkCore;

namespace ASPPTraining1.Context
{
    public class ASPContext:DbContext
    {
        public DbSet<WebUser> WebUsers { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<University> Universities { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Server=.;Database=ASPTraining2;Trusted_Connection=true");
        }
    }
}
