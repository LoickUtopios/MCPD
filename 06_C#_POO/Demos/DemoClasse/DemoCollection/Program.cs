/*
 * LES COLLECTIONS
 * -------------------------------------------
 * Une collection est un ensemble de données d'un même type (comme les tableaux).
 * Cependant elles ont quelques spécificités :
 *      - La taille d'une collection est dynamique.
 *      - Elles n'ont pas besoin de réserver d'espaces adjacents en mémoire.
 *      - Elles implémentent toutes l'interface IEnumerable
 *      - Elles possèdent des méthodes afin d'ajouter, supprimer, chercher ou trier.
 * 
 */


/* LIST
 * -------------------
 * La liste est une collection ordonnée (avec des index) d'un type spécifique.
 * 
 * Utilisation : Elle est polyvalente est peut être utilisé un peu partout.
 * 
 */

// Déclaration et affectation d'une liste vide
using DemoCollection.Classes;

List<string> listeDeStrings  = new List<string>();

// Pour ajouter des éléments à une liste, nous pouvons utiliser la méthode Add. 
listeDeStrings.Add("Toto");
listeDeStrings.Add("Tata");
listeDeStrings.Add("Titi");

// On peut accéder au élément d'une liste de la même manière qu'un tableau (via son index) 
listeDeStrings[0] = "Toto Tolto 9";   

foreach (string str in listeDeStrings)
{
    Console.WriteLine(str);
}

// liste.Count équivaut au tableau.Length (affiche le nombre d'élément dans la liste)
Console.WriteLine("Il y a " + listeDeStrings.Count + " chaine dans la liste.");

// Nous pouvons déclarer, affecter et instancier une liste sur le même ligne.
List<int> listeDeInt =  new List<int>() { 1, 5, 8, 15, 2, 4, 7, 6, 3, 3, 1, 8};

listeDeInt.Add(0);
listeDeInt.Remove(8); // Supprime le premier '8' trouvé (ne fait rien sinon)
listeDeInt.RemoveAt(6); // Supprime l'élément d'indice 6 (ici, le 6)

listeDeInt.Sort(); // Permet de trié la liste (par ordre croissant ou alphabétique)

// La méthode Contains permet de vérifier si un élément est présent dans la liste (renvoie un booléen)
if (listeDeInt.Contains(15))
    Console.WriteLine("Il y a un 15 dans la liste"); 

for(int i = 0; i < listeDeInt.Count; i++)
{
    Console.Write(listeDeInt[i] + ", ");
}
Console.WriteLine();

listeDeInt.Clear(); // Vide entièrement la liste

Console.WriteLine("Il reste " + listeDeInt.Count + " élément(s) dans la liste.");


List<User> toutLesUtilisateurs = new List<User>();
toutLesUtilisateurs.Add(new User(1, "Marco", "marco@perdu.com")); 
toutLesUtilisateurs.Add(new User(2, "Polo", "polo@dans.com")); 
toutLesUtilisateurs.Add(new User(3, "Marlo", "marlo@lePacifique.com")); 

foreach (User user in toutLesUtilisateurs)
{
    user.SePresenter(); // Utilise la méthode de chaque utilisateur dans la liste
}

/* HASHSET
 * -------------------
 * Un Hashset est une liste qui ne contient AUCUN doublon.
 * 
 * Utilisation : Elle peut être utilisé dans les cas ou l'on ne veut une information qu'une fois
 * Exemple : Tout les mails des employés.
 * 
 */

HashSet<string> noms =  new HashSet<string>();
noms.Add("Arnaud");
noms.Add("Arnaud"); // Ignoré à l'ajout 
noms.Add("Bob");
noms.Add("Bob"); // Ignoré à l'ajout 

Console.WriteLine("Contenue du HashSet :");
foreach(string nom in noms)
{
    Console.WriteLine(nom);
}

/* SortedSet / SortedList / SortedDictionnary
 * -------------------
 * Une collection Sorted, va trié automatiquement la liste à chaque insertion.
 * 
 * Attention, car elle demande plus de performance qu'une liste standard.
 * 
 */

SortedSet<string> listeTrieDeStr = new SortedSet<string>() {"Zoo", "Barbare", "Horloge"};
Console.WriteLine("Contenue du SortedSet :");

foreach (string str in listeTrieDeStr)
    Console.WriteLine(str);

/* Dictionary
 * -------------------
 * Un dictionnaire est une collection dont l'index est également donnée.
 * Il y a donc une paire clé-valeur se forme.
 * 
 */

// Pour déclarer un dictionnaire, nous devons fournir 2 type. 
// Le type pour la clé et un type pour la valeur.
Dictionary<string, int> ageDesPersonnes = new Dictionary<string, int>();
ageDesPersonnes["Victor"] = 20;
ageDesPersonnes["Loick"] = 30;

// Accès à une valeur via la clé
Console.WriteLine("Age de Victor :" + ageDesPersonnes["Victor"]);

// Pour parcourir, la totalité d'un dictionnaire, nous devons récupérer la paire clé-valeur dans un type var
foreach (var paire in ageDesPersonnes)
{
    // Il ne reste plus qu'a afficher l'élément en question.
    Console.WriteLine($"{paire.Key} => {paire.Value}");
}


