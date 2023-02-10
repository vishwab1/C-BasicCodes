using Microsoft.EntityFrameworkCore;
using MyWebMVCApplication.Models;

namespace MyWebMVCApplication.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
