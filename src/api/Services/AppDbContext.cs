using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Services
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}