
/* -------------------------------------------------------
 * Tableaux
 * -------------------------------------------------------
 * 
 * Une collection de donnés d'un même type avec une taille FIXE
*/

/*
    Déclaration d'un tableau

    Un tableau est une référence vers une zone en mémoire
    A ce stade, aucune mémoire n'est encore alloué
*/

int[] t;

/*
    Allocation de mémoire avec new
    La taille indique le nombre d'élément du tableau.
*/ 

t = new int[2];
Console.WriteLine("Le tableau est alloue avec une taille de 2");
Console.WriteLine("On peut récupérer la taille avec .Length : " + t.Length);
Console.WriteLine();

/*
    Déclaration + Allocation
*/

string[] mots = new string[5];

/*
    Initialisation manuelle des valeurs
    
    Les index commencent à 0 et vont jusqu'a Length - 1;
*/

t[0] = 10;
t[1] = 20;

Console.WriteLine("Affichage des valeurs après initialisations : ");
Console.WriteLine(t[0]);
Console.WriteLine(t[1]);
Console.WriteLine();

/*
    Déclaration + Initialisation
*/

float[] valeur = new float[] {2.5f, 3.0f, 5.0f, 4.4f};
float[] valeur2 = { 2.5f, 3.0f, 5.0f, 4.4f };

Console.WriteLine("Taille de 'valeur' avec .Length :" + valeur.Length);

Console.WriteLine("Tableau 'valeur' : ");
Console.WriteLine(valeur2[0]);
Console.WriteLine(valeur2[1]);
Console.WriteLine(valeur2[2]);
Console.WriteLine(valeur2[3]);
Console.WriteLine();

/* 
 * Copie de tableau par référence (fausse copie)
 * 
*/ 

int[] tab = {1 ,2 ,3};
int[] tab2;

tab2 = tab;

Console.WriteLine("La taille de tab 2 est : " + tab2.Length);
Console.WriteLine("tab 2 : ");
Console.WriteLine(tab2[0]);
Console.WriteLine(tab2[1]);
Console.WriteLine(tab2[2]);

tab[0] = 5;
Console.WriteLine("tab2[0] après modification de tab[0] : " + tab2[0]);
Console.WriteLine();

/* 
 * Copie de tableau (Clone)
 * 
 * Clone créer un nouveau tableau INDEPENDANT avec les même valeurs que l'original.
 * 
*/

int[] original = {4, 5, 6};
int[] copie = (int[]) original.Clone();

original[0] = 100;

Console.WriteLine("Tableau original : ");
Console.WriteLine(original[0] + " , " + original[1] + " , " + original[2]);

Console.WriteLine("Tableau copie : ");
Console.WriteLine(copie[0] + " , " + copie[1] + " , " + copie[2]);

Console.WriteLine();

/*
 *  Parcours d'un tableau (foreach)
 *  
 *  - for : pratique si on a besoin de l'index ou de faire des modification
 *  - foreach : pratique pour lire chaque élément
 *
*/

int[] notes = { 8, 10, 12, 14, 16 };

Console.WriteLine("Parcours des notes avec for (avec un index) : ");

for(int i = 0; i < notes.Length; i++)
{
    Console.WriteLine(notes[i]);
    notes[i] = 0;
}
Console.WriteLine();

for (int i = 0; i < notes.Length; i++)
{
    Console.WriteLine(notes[i]);
}

Console.WriteLine("Parcours des notes avec foreach : ");

foreach (int note in notes)
{
    Console.WriteLine(note);

}
Console.WriteLine();