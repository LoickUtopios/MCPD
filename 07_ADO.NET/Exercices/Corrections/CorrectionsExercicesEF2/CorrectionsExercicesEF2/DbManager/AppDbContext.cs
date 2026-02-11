using CorrectionsExercicesEF2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionsExercicesEF2.DbManager
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Chambre> Chambres { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;database=ef;uid=root;pwd=",
                ServerVersion.AutoDetect("server=localhost;database=ef;uid=root;pwd=")
                );
        }
    }
}
