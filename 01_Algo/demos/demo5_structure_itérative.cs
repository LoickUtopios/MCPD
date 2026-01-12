// Structure itératives

Console.WriteLine("Saisir un prénom : ");
string? prenom = Console.ReadLine();

// On utilise une boucle while ou do..while quand on ne connait pas à l'avance le nombre d'itérations.
while(prenom != "Toto")
{
    Console.WriteLine("Erreur. Ce n'est pas le bon prenom. (indice : commence par 'To' et finis 'to')");
    Console.WriteLine("Saisir un prénom : ");
    prenom = Console.ReadLine();
}

int compteur = 0;
// Permet d'avoir un nombre aléatoire.
int limit = new Random().Next(5, 20); 

while(compteur < limit)
{
    Console.WriteLine(compteur);
    compteur++;
}

// Boucle For (cette boucle est utilisé quand le nombre d'itération est connue)
// for(compteur initial; condition; pas)
Console.WriteLine("Boucle for croissante avec pas de 1 allant de 0 à 9");
for(int i = 0; i < 10; i++)
{
    Console.WriteLine(i); 
}

Console.WriteLine("Boucle for décroissante avec pas de -1 allant de 10 à 1");
int j; 
// Nous pouvons changer le pas de notre compteur de manière décroissante avec le j-- 
for(j = 10; j > 0; j--)
{
    Console.WriteLine(j);
}


Console.WriteLine("Boucle for croissante avec pas de 3 allant de 0 à 20");
// Nous pouvons également donner un pas particulier avec k = k + ? 
for (int k = 0; k < 20; k = k + 3)
{
    Console.WriteLine(k);
}

// Une boucle While peut faire le même travail qu'une boucle For mais elle est moins concise.
//int compteur2 = 0;

//while(compteur2 < 10)
//{
//    Console.WriteLine(compteur2++);
//}

// La boucle Do..While va effectuer le même travail qu'une boucle While, à la différence
// que les instructions sont effectué au moins une fois.

Console.WriteLine("Boucle do..while");
int age = 20;

do
{
    Console.WriteLine(age);
    age++;
}while (age < 18);