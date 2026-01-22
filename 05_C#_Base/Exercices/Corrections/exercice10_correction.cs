//# Exercice 10

//Demander à l’utilisateur de saisir un entier strictement positif.
//Tant que l’utilisateur ne saisit pas un entier valide (> 0), redemander la saisie.

//Une fois la valeur valide saisie, afficher tous les nombres de `1` jusqu’à ce nombre, **un par ligne**, à l’aide d’une boucle `while`.

int askUser()
{
    int userSaisie;

    bool validSaisie;

    do
    {
        Console.WriteLine("Veuillez saisir un entier positif");
        validSaisie = int.TryParse(Console.ReadLine(), out userSaisie);
    }while (!validSaisie || userSaisie <= 0);

    return userSaisie; 
}

int a = askUser();
int defaultNumber = 1;

while(defaultNumber <= a )
{
    Console.WriteLine(defaultNumber);
    defaultNumber++;  
}
