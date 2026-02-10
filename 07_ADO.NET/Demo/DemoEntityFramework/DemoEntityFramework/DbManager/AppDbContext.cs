using DemoEntityFramework.Model;
using Microsoft.EntityFrameworkCore;

namespace DemoEntityFramework.DbManager
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Personne> Personne {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;database=ef;uid=root;pwd=",
                ServerVersion.AutoDetect("server=localhost;database=ef;uid=root;pwd=")
                );
        }

    }
}
