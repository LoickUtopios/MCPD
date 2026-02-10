using DemoEntityFramework.Model;
using Microsoft.EntityFrameworkCore;
using Test.Model;

namespace DemoEntityFramework.DbManager
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Personne> Personne {  get; set; }

        public DbSet<Commande> Commande { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;database=ef;uid=root;pwd=",
                ServerVersion.AutoDetect("server=localhost;database=ef;uid=root;pwd=")
                );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Commande>()
            //            .HasOne(c => c.Personne)
            //            .WithMany() // pas de propriété de navigation côté Personne
            //            .HasForeignKey(c => c.PersonneId)
            //            .OnDelete(DeleteBehavior.Cascade);
        }


    }
}
