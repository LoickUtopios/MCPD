using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3.Classes
{
    internal class Personnage
    {
        private string _name;
        private int _health;
        private int _damage;

        public string Name { get { return _name; } set { _name = value; } }
        public int Health { get { return _health; } set { _health = value; } }
        public int Damage { get { return _damage; } set { _damage = value; } }


        public Personnage(string name, int health, int damage) 
        { 
            Name = name;
            Health = health;
            Damage = damage;
        }

        public bool IsAlive()
        {
            return Health > 0;
        }

        public void Attack(Personnage enemy)
        {
            enemy.Health = enemy.Health - Damage;
            Console.WriteLine($"{Name} a attaqué {enemy.Name}."); 
            Console.WriteLine($"Il reste {enemy.Health} pv à {enemy.Name}");
        }

    }
}
