//# Exercice 16

//Un tableau de taille 5 doit contenir des âges.

//Le programme doit :

//1.Demander à l’utilisateur de saisir 5 âges.
//2. Refuser toute valeur négative ou supérieure à 120.
//3. Stocker uniquement les valeurs valides dans le tableau.
//4. Afficher à la fin :

//   -le tableau complet
//   - le nombre d’âges invalides saisis

int[] ages = new int[5];
int ageIndex = 0;
int nbAgeInvalide = 0;

do
{
    Console.WriteLine("Veuillez saisir un age (0-120) : ");

    bool ageValid = int.TryParse(Console.ReadLine(), out int age);

    if(ageValid && age >= 0 && age <= 120)
    {
        ages[ageIndex] = age;
        ageIndex++;
    }
    else
    {
        nbAgeInvalide++;
    }

}while (ageIndex < ages.Length);

Console.WriteLine($"Vous avez saisie {nbAgeInvalide} age invalides...");

foreach( int age in ages)
{
    Console.Write(age + " , ");
}