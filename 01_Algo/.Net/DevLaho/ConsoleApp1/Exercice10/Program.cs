Console.Write("Veuillez saisir un nombre (entre 1 et 3) : ");
int nombre = int.Parse(Console.ReadLine());

while (nombre < 1 || nombre > 3)
{
    Console.WriteLine("Veuillez réessayer !");
    nombre = int.Parse(Console.ReadLine());
}