using imdb.Models;
using Microsoft.EntityFrameworkCore;

namespace imdb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
             
        }
        public DbSet<User> Users { get; set; }
    }
}
