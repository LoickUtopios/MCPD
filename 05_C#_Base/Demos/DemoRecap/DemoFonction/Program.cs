/* ----------------------------------------------------------
 * Fonctions / Méthodes
 * ----------------------------------------------------------
 * 
 * Une fonction est un bloc de code réuitilisable
 * Elle peut :
 *      - Ne rien retourner (void)
 *      - retourner une valeur
 *      - recevoir des paramètres
 */

// Déclaration d'une fonction (sans retour / procédure)
// Syntaxe : TypeRetour NomFonction (typeParam nomParam, ...) { instructions; }
void DireBonjour()
{
    Console.WriteLine("Bonjour !"); 
}

// Appel de la fonction

DireBonjour();
Console.WriteLine(); 

// Fonction avec paramètres
void DireSalue(string prenom)
{
    Console.WriteLine("Salut " + prenom);
}

DireSalue("Victor");
Console.WriteLine();

// Fonction avec valeur de retour

int Addition(int a, int b)
{
    return a + b;
}

int resultat = Addition(5, 3);
Console.WriteLine("Résultat de l'additon : " + resultat);
Console.WriteLine("Résultat de l'additon : " + Addition(2, 2));

// Fonction avec tuple en retour

(int min, int max) MinMax(int[] tableau)
{
    int min = tableau[0]; 
    int max = tableau[0];
    
    foreach(int valeur in tableau)
    {
        if (valeur < min) 
            min = valeur;

        if (valeur > max) 
            max = valeur;
    }

    return (min, max); 
}

int[] valeurs = { 3, 7, 4, 5, 9 };
(int min, int max) minAndMax = MinMax(valeurs);
var tuple = MinMax(valeurs);

Console.WriteLine(minAndMax.max + ", " + minAndMax.min);
Console.WriteLine(tuple.max + ", " + tuple.min);


// Fonction avec un parametre par défaut
// Attention de bien placé les valeurs par défaut à droite (sinon vous devrez renseigner tout les champs)
void Saluer(int age, string nom = "Toto")
{
    Console.WriteLine("Salutation de " + nom);
}

Saluer(10);
Saluer(20, "Juan");
Console.WriteLine();

// Fonction avec passage par références

void Doubler(int nb)
{
    nb = nb * 2;
}

void DoublerParReference(ref int nb)
{
    nb = nb * 2;
}

// Il n'est pas nécessaire de donner le mot-clé ref sur un tableau car elle est déjà une référence.
// Attention car sans copie, vous modifierai l'original par défaut.
void DoublerTableau(int[] nb)
{
    for(int i = 0; i < nb.Length; i++)
    {
        nb[i] = nb[i] * 2; 
    }
}

int nombre = 5;
Doubler(nombre);
Console.WriteLine("Sans ref : ");
Console.WriteLine(nombre);

DoublerParReference(ref nombre);
Console.WriteLine("Avec ref : ");
Console.WriteLine(nombre);

int[] nbTab = { 2, 3, 4 };
Console.WriteLine("Tableau : ");
DoublerTableau(nbTab);

foreach(int n in nbTab)
    Console.Write(n + " ");

/*
 * Paramètre out
 * 
 * La fonction DOIT recevoir une variable depuis l'appel.
 * 
 */

void Calculer (int a, int b, out int somme, out int produit)
{
    somme = a + b;
    produit = a * b;
}

Calculer(5, 3, out int s, out int p);
Console.WriteLine("La somme est " + s);
Console.WriteLine("Le produit est " + p);

/*
 * Paramètre params
 * 
 * Permet de passer un nombre VARIABLE d'arguments dans un tableau
 * 
 */

int Somme(params int[] nombres)
{
    int total = 0;

    foreach (int n in nombres)
    {
        total += n;
    }

    return total;
}

int Difference(int nb1, int nb2, params int[] nombres)
{
    int total = 0;
    total -= nb1;
    total -= nb2;
    foreach (int n in nombres)
    {
        total -= n;
    }

    return total;
}

Console.WriteLine("Somme 0 : " + Somme());
Console.WriteLine("Somme 1 : " + Somme(1, 2));
Console.WriteLine("Somme 2 : " + Somme(1, 2, 3, 4));
Console.WriteLine("Somme 3 : " + Somme(1, 2, 3, 4, 5, 6));

// Console.WriteLine("Somme 0 : " + Difference()); // Ici erreur, car 2 parametre sont obligatoire
Console.WriteLine("Difference 1 : " + Difference(1, 2));
Console.WriteLine("Difference 2 : " + Difference(1, 2, 3, 4));
Console.WriteLine("Difference 3 : " + Difference(1, 2, 3, 4, 5, 6));