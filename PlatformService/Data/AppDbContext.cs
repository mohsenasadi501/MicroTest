using Microsoft.EntityFrameworkCore;
using MicroTest.Models;

namespace MicroTest.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
        }
        public DbSet<Platform> Platforms { get; set; }
    }
}
