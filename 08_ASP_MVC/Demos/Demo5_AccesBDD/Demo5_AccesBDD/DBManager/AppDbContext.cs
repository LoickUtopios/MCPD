using Demo5_AccesBDD.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo5_AccesBDD.DBManager
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
    }
}
