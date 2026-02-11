using CorrectionExercicesEF1.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExercicesEF1.DbManager
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Adresse> Adresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;database=ef;uid=root;pwd=",
                ServerVersion.AutoDetect("server=localhost;database=ef;uid=root;pwd=")
                );
        }


    }
}
