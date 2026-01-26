//# Exercice 15

//Un programme dispose d’un tableau d’entiers représentant des valeurs mesurées par un capteur.

//- Certaines valeurs peuvent être aberrantes (négatives).
//- Une valeur aberrante doit être ignorée.

//Écrire un programme qui :

//1.Parcourt le tableau.
//2.Ignore les valeurs négatives.
//3. Calcule et affiche :

//   -le nombre de valeurs valides
//   - la somme des valeurs valides
//   - la moyenne des valeurs valides (si possible)

int[] valeurs = { 3, 5, 9, -2, -4, 12, -6, 7, 8};

int nbValide = 0;
int somme = 0;

foreach (int val in valeurs)
{
    if (val > 0)
    {
        nbValide++;
        somme += val;
    }
}

Console.WriteLine($"Dans le tableau, il y a {nbValide} valeurs valides.");
Console.WriteLine("La somme de ces valeurs est de : " + somme);
Console.WriteLine("La moyenne de ces valeurs est de : " + ((float)somme / nbValide)); 
