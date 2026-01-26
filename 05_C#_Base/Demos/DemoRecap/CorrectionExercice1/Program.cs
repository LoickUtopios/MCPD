//# Exercice 19

//Un tableau contient une suite de nombres entiers.

//Le programme doit vérifier si le tableau respecte **la règle suivante** :

//> Chaque nombre doit être **strictement supérieur** au précédent.

//- Si la règle est respectée, afficher :
//  `"La suite est strictement croissante"`
//-Sinon, afficher:
//  `"La suite n'est pas strictement croissante"`

int[] nbs = { 1, 2, 3, 2, 5, 6, 7, 8, 9 };

bool estCroissante = true;

for(int i = 0; i < nbs.Length - 1; i++)
{
    if(nbs[i] > nbs[i + 1])
    {
        Console.WriteLine("La suite n'est pas strictement croissante");
        estCroissante = false;
        break;
    }

}

if (estCroissante)
{
    Console.WriteLine("La suite est strictement croissante.");
}