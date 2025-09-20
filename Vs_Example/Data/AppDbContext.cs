using Microsoft.EntityFrameworkCore;
using Vs_Example.Models;

namespace Vs_Example.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) :base(dbContextOptions) { }
        public DbSet<Person> People { get; set; }
    }
}
