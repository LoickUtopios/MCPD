using Exercice6.Classes;

string ChoisirParametre()
{
    string choix = ""; 
    do
    {
        Console.WriteLine("=== Paramètres de partie ===");
        Console.Write("Voulez vous un nombre d'essais spécifique (10 par défaut) ? Y/n  ");
        choix = Console.ReadLine() ?? "";
        choix = choix.ToLower();
        Console.WriteLine();

        if (choix == "y" || choix == "n")
            break;

    } while (true);

    return choix;
}

int ChoisirNbEssais()
{
    Console.Write("Combien voulez-vous d'essais : ");
    bool choixOK = int.TryParse(Console.ReadLine(), out int result);

    if (result <= 0)
    {
        Console.WriteLine("Nombre d'essais incorrecte, retour à la valeur par défaut.");
        result = 10;
    }
    return result;
}

void LancerPartie(int nbEssaisTotal)
{
    Pendu pendu = new Pendu(Generateur.GenereMot(), nbEssaisTotal);

    do
    {
        Console.WriteLine("Le mot à trouver : " + pendu.Mask);
        Console.WriteLine("Il vous reste " + pendu.NbEssai + " essais");
        Console.WriteLine();

        Console.WriteLine("Veuillez saisir une lettre : ");
        char lettre = Console.ReadLine().ToUpper()[0];

        if (pendu.TestChar(lettre))
        {
            pendu.Mask = pendu.GenereMasque(lettre);

            if (pendu.TestWin())
            {
                Console.WriteLine("Mot trouvé : " + pendu.MotATrouver); 
                Console.WriteLine($"Victoire en {nbEssaisTotal - pendu.NbEssai} essais !");
                break;
            }

        }
        else
        {
            if (pendu.NbEssai == 0)
            {
                Console.WriteLine("Perdu...");
                break;
            }
        }
    } while (true);
}

do
{
    string choix = ChoisirParametre();
    int nbEssais = 10;

    if (choix == "y")
    {
        nbEssais = ChoisirNbEssais();
    }


    LancerPartie(nbEssais);

    Console.WriteLine("Voulez-vous relancer une partie ? (Y/n) ");

    if (Console.ReadLine().ToLower() != "y")
        break;

    Console.Clear(); 

} while (true);





