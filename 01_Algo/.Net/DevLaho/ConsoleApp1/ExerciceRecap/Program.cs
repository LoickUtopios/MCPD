
for (int i = 10; i <= 30; i++)
{
    if(i % 2 == 0)
        Console.WriteLine(i);
}

string nom;
int age;

do
{
    Console.WriteLine("Veuillez entrer votre nom : ");
    nom = Console.ReadLine();

    Console.WriteLine("Veuillez entrer votre age : ");
    age = int.Parse(Console.ReadLine());

    if(nom != "toto") 
        Console.WriteLine("Vous n'avez pas le bon nom..");

    if (age < 18)
        Console.WriteLine("Vous êtes mineur...");

} while(nom != "toto" || age < 18);

Console.WriteLine("Veuillez entrer un nombre : "); 
int nb = int.Parse(Console.ReadLine());

Console.WriteLine("Le carré de "+ nb + " est de " + Math.Pow(nb, 2));
Console.WriteLine($"Le carré de {nb} est de {Math.Pow(nb, 2)}");