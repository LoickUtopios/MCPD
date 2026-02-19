using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice6.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercice6.DBManager
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students {  get; set; }
       
    }
}
