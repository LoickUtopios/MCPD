
Console.WriteLine("Veuillez saisir votre age : ");

string? saisieUtilisateur = Console.ReadLine();
int age = int.Parse(saisieUtilisateur);

//int age = int.Parse(Console.ReadLine());

if(age >= 18)
{
    Console.WriteLine("Vous êtes majeur");
}
else
{
    Console.WriteLine("Vous êtes mineur");
}

