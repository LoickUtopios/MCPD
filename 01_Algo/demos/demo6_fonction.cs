// Définition d'une fonction
// TypeRetour NomFonction (parametres => optionnelles)
int addition(int nb1, int nb2) // signature d'une fonction
{
    int resultat = nb1 + nb2;
    return resultat; // Le mot-clé return permet de renvoyer la valeur donnée.
}

int resultat = addition(5, 7); // Appel de la fonction "addition" 
Console.WriteLine(resultat);

resultat = addition(2, 4); // 2e appel de la même fonction
Console.WriteLine(resultat);

Console.WriteLine(addition(10,15));

// Définition d'une procédure
void presentation(string nom, string prenom, int age) // parametres 
{
    Console.WriteLine($"Bonjour, je m'appel {prenom} {nom} et j'ai {age} ans.");
}

//Appel de la procédure
presentation("Walle", "Loïck", 31); // arguments


// Pour les types primitifs (int, float, double, string,..), les arguments sont envoyés par valeurs
// Les informations sont donc copié.
int age = 10;

int anniversaire(int age)
{
    age += 1;
    return age;
}

Console.WriteLine(age);
Console.WriteLine(anniversaire(age));
Console.WriteLine(age);