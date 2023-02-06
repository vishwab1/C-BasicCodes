using Microsoft.EntityFrameworkCore;
using SimpleCWeb.Models;

namespace SimpleCWeb.DatabaseConfig
{
    public class ApplicationDBContext : DbContext

    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<User> UserDetails { get; set; }
    }
}