using Microsoft.EntityFrameworkCore;

namespace AspNetCoreTest.Data
{
    public class PersonDbContext : DbContext // = Database
    {
        public DbSet<Person> People { get; set; } // = Table 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Initial Catalog=PersonTestDb;Integrated Security=True;");
        }
    }
}
