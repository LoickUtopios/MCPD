//# Exercice 17

//Un tableau d’entiers est donné.

//Le programme doit déterminer si **deux valeurs consécutives identiques** existent dans le tableau.

//- Si oui, afficher un message indiquant qu’une répétition a été trouvée.
//- Sinon, afficher un message indiquant qu’aucune répétition n’existe.

int[] tableau = { 1, 2, 3, 4, 5, 5, 7, 8, 9 }; 

bool seRepete = false;

for(int i = 0; i < tableau.Length - 1; i++)
{
    if (tableau[i] == tableau[i + 1])
    {
        Console.WriteLine("Deux valeurs consécutives identiques !");
        seRepete = true;
        break;
    }
}

if (!seRepete)
{
    Console.WriteLine("Aucune répétition dans se tableau");
}