// Déclarer un tableau de 5 case
int[] tableau = new int[5];

// Afficher la première valeur d'un tableau (pour l'instant vide ou valeur par défaut)
Console.WriteLine(tableau[0]);

// Affectation des valeurs dans le tableau
tableau[0] = 1;
tableau[1] = 2; 
tableau[2] = 3;
tableau[3] = 4;
tableau[4] = 5;

Console.WriteLine(tableau[4]);

// Allocation et affectation
int[] tableau2 = [1, 2, 3, 4];
string[] tableau3 = new string[] { "Un", "Deux", "Trois"};

// Pour connaitre la taille d'un tableau, nous avons l'attribut Length.
Console.WriteLine(tableau2.Length);

// Parcourir un tableau avec un for
Console.WriteLine("je parcours le tableau 2 : ");
for(int i = 0; i < tableau2.Length; i++)
{
    Console.WriteLine(i + " : " + tableau2[i]);
}

// Parcourir un tableau avec foreach (parcours tout le tableau)
Console.WriteLine("je parcours le tableau avec foreach : ");
foreach (int valeur in tableau)
{
    Console.WriteLine(valeur);
}

char[] mot = ['a', 'b', 'c']; // Tableau de caractere
string chaine = "test"; // Un string est un tableau de caractere (mais immuable)

Console.WriteLine(chaine[0]); // premiere lettre de la chaine de caractere

foreach(char lettre in chaine)
{
    Console.WriteLine(lettre);
}

// Déclaration
int[][] matrice1 = new int[3][];
matrice1[0] = new int[15];
matrice1[1] = new int[15];
matrice1[2] = new int[15];

int[,] matrice2 = new int[3,15];
matrice2[0, 0] = 1;
matrice2[0, 1] = 2; 


// Déclaration et affectation d'une matrice
int[][] matrice = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

Console.WriteLine(matrice[1][1]); // 5
Console.WriteLine(matrice[2][0]); // 7

foreach(int[] ligne in matrice)
{
    Console.WriteLine(ligne);
    foreach(int val in ligne)
    {
        Console.Write(val + " , ");
    }
}