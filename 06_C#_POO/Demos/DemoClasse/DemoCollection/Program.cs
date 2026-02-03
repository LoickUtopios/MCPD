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
    user.SePresenter();    
}