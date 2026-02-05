using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoException.Classes
{
    internal class User
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public int Age { get; set; }

        public User(int id, string nom, string prenom, int age)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }
    }
}
