
using Exercice3.Classes;

Personnage gimli = new Personnage("Gimli", 50, 10);
Personnage legolas = new Personnage("Legolas", 30, 5);

do
{
    gimli.Attack(legolas);

    if(legolas.IsAlive())
        legolas.Attack(gimli);

} while (gimli.IsAlive() && legolas.IsAlive());

if (gimli.IsAlive())
    Console.WriteLine($"{gimli.Name} a gagné !!");
else
    Console.WriteLine($"{legolas.Name} a gagné !!");