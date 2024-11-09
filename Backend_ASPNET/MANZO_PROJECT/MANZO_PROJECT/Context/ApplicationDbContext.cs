using MANZO_PROJECT.Models;
using MANZO_PROJECT.Models.MANZO_PROJECT.Models;
using Microsoft.EntityFrameworkCore;

namespace MANZO_PROJECT.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product>products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }


    }
}
