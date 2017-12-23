using Microsoft.EntityFrameworkCore;
using System.Linq;
using api.Models;

namespace api.Services
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) :
            base(dbContextOptions)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}