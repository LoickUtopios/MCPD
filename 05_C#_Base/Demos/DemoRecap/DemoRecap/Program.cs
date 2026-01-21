// Commentaire rapide en C#

/*
    Commentaire sur plusieurs lignes
*/

// Déclaration + Affectation
// type nom = valeur;
using System.ComponentModel.DataAnnotations;

string nom = "Toto";

// Type possible en C# 
sbyte unOctet;      // -128 127 
byte octerPositif;  // 0 255 
short unPetitNombre;// entier sur 2 octet => -32000 32000
int age;            // entier sur 4 octet => -2 milliard 2 milliard
long presqueInfinie;// entier sur 8 octet  => Très grand

bool estVrai;       // Booléen => Vrai / Faux

float distance;     // décimal sur 4 octet 
double monnaie;     // décimal sur 8 octet (plus précis)

string chaineDeMot; // chaine de caractere
char uneLettre;     // un seul caractere

presqueInfinie = 100_000_000L;
distance = 12.5f; // pour un float, nous devons ajouter un 'f' à la fin
chaineDeMot = "Ceci est une phrase";
uneLettre = 'a';



// Interaction Console : Affichage (Write Line/ Write)

// Console.WriteLine(...) : écrit un texte puis ajoute un saut de ligne.
// Console.Write(...) : écrit un texte sans ajout d'un saut de ligne.

Console.WriteLine("Affichage direct");
Console.WriteLine(presqueInfinie);
Console.WriteLine(chaineDeMot);

Console.Write("Bonjour");
Console.Write(" à tous");

Console.WriteLine(); // retour à la ligne sans écriture.

Console.WriteLine("\tBonjour avec une tabulation."); // \t permet d'effectuer une tabulation
// \n permet de faire un retour à la ligne manuellement.
Console.Write("Bonjour \nJ'effectue un saut de ligne\navec plusieurs saut\nd'affilé\n");

// Interaction Console : Lecture clavier (ReadLine)

// Console.ReadLine(...) : lit la chaine écrite dans la console

Console.WriteLine("Quel est votre nom ?"); 
string nomUtilisateur = Console.ReadLine();

Console.WriteLine("Votre nom est " + nomUtilisateur); // Concaténation 

Console.WriteLine("Quel est votre prenom ?");
string? prenomUtilisateur = Console.ReadLine(); // string? va récupérer une chaine ou null

Console.WriteLine("Quel est votre age ?");
int ageUtilisateur = int.Parse(Console.ReadLine()); // Parse va permttre la conversion de string vers int

// L'interpolation permet d'ajouter des variables dans une chaine directement (sans +).
Console.WriteLine($"Votre prenom est {prenomUtilisateur} et vous avez {ageUtilisateur} ans.");

// Cast : transformer un type en un autre type

// Cast implicite

short petitNombre = 5;
int nombre = petitNombre;

float nombreAVirgule = petitNombre; // Un nombre décimal pour récupérer un entier de façon implicite (attention à la taille)

// Cast explicite

nombre = 100_000;
petitNombre = (short) nombre; // Grand vers petit (de la même famille)

string nombreEnChaine = "255";
petitNombre = short.Parse(nombreEnChaine);

// Opérateur arithmétique

// Pour calcul standart nous utilisons : + , - , *, /, % (modulo)
// Incrémentation + Décrémentation 
int compteur = 0;

compteur++; // compteur = compteur + 1;
compteur += 5; // compteur = compteur + 5

Console.WriteLine(compteur++); // si le ++ est à la fin, l'incrémentation est faite après l'instruction.
Console.WriteLine(++compteur);// si le ++ est au début, l'incrémentation est faite avant la lecture de l'instruction.

compteur--; // compteur = compteur - 1
compteur -= 5; // compteur = compteur - 5;

compteur *= 2; // compteur = compteur * 2;

// Opérateur expressions

int value1 = 1;
int value2 = 2;
bool resultat;

resultat = value1 == value2; // false

resultat = value1 <= value2; // true
resultat = value1 < value2; //true
resultat = value1 > value2; // false
resultat = value1 >= value2; // false

resultat = value1 != value2; // true

// Opérateur logique

resultat = true && true; // ET (les 2 conditions doivent être vrai)
resultat = true || false; // OU (une des conditions doit être vrai)
resultat = !false; // NOT (l'inverse de la condition donnée)

resultat = (true && false) || true || (false || false); // true

// Structures condionnelles

// if..else if...else

if(3 > 2)
    Console.WriteLine("3 est supérieur à 2");

int note = 18;

if(note >= 16)
{
    Console.WriteLine("Très bien !");
}
else if(note >= 10)
{
    Console.WriteLine("Bien");
}
else
{
    Console.WriteLine("Assez bien"); 
}

// Switch : choix parmi plusieurs cas
Console.WriteLine("1- Dire bonjour");
Console.WriteLine("2- Dire au revoir");
Console.WriteLine("3- Dire bonne nuit");

int choix = 5;

switch (choix)
{
    case 1:
        Console.WriteLine("Bonjour !!!!");
        break;
    case 2:
        Console.WriteLine("Au revoir !!!");
        break;
    case 3:
        Console.WriteLine("Bonne nuit ~~~~"); 
        break;
    default:
        Console.WriteLine("Mauvais choix !!"); 
        break;
}

// switch expression (renvoie une valeur)
string messageChoix = choix switch
{
    1 => "Bonjour !!!",
    2 => "Au revoir !!",
    3 => "Bonne nuit !!!",
    _ => "Je n'ai pas un choix valide !"
};

// switch expression - avec expression dans les cases 
int valeur = 15; 

string result = valeur switch
{
    <10 => "La valeur est inférieur à 10",
    >10 and <20 => "La valeur est compris entre 10 et 20",
    21 or 22 => "La valeur est 21 ou 22", 
    _ => "La valeur est 23 ou plus"
};

// Ternaire (condition simple - if..else)
int userAge = 20; 

bool majeur = userAge >= 18 ? true : false; // condition ? result si vrai : resultat si faux

// Null coalescing operateur ?? 

string? chaine1 = null;

string name= chaine1 ?? "TOTO"; // name = "TOTO" car chaine1 est null

chaine1 ??= "TITI"; // chaine1 étant null, il devient "TITI"
chaine1 ??= "TATA"; // chaine n'est pas null, il reste "TITI"

string? job = Console.ReadLine();
job ??= "Etudiant"; // Si l'utilisateur donne une valeur null alors job sera "Etudiant".
