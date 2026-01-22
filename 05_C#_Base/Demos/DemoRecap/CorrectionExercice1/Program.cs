//# Exercice 11 Deviner un nombre (do…while)

//Le programme choisit un nombre fixe (par exemple `7`).
//L’utilisateur doit deviner ce nombre.

//- Tant que l’utilisateur n’a pas trouvé le bon nombre, le programme redemande une saisie.
//- Quand le nombre est trouvé, afficher `Bravo, nombre trouvé !`.

const int nombreSecret = 7;

// Aléatoire
Random rdm = new Random();
int nombreSecretRandom = rdm.Next(1, 10);

int proposition;

do
{
    Console.WriteLine("Deviner le nombre entre 1 et 10 : "); 
    string? saisie = Console.ReadLine();

    if(!int.TryParse(saisie, out proposition))
    {
        Console.WriteLine("Saisie invalide. Entrer un entier :");
        saisie = Console.ReadLine();
    }

    if (proposition == nombreSecretRandom)
    {
        Console.WriteLine("Bravo, nombre trouvé !");
        break;
    }
    else if (proposition < nombreSecretRandom)
        Console.WriteLine("Plus grand !");
    else
        Console.WriteLine("Plus petit !");

} while(true);

