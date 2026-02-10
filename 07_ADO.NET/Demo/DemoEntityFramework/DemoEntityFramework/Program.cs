
using DemoEntityFramework.DbManager;
using DemoEntityFramework.Model;
using Microsoft.EntityFrameworkCore;


/*
    Entity Framework Core (EF Core) est un ORM (Object-Relational Mapper) pour .NET.
    Il permet de manipuler des bases de données via des classes C# (entités) au lieu d’écrire directement du SQL.
    
    Avec EF Core, vous pouvez :
        - Créer la base et les tables à partir des classes (Code First)
        - Effectuer des opérations CRUD (Create, Read, Update, Delete) via LINQ
        - Gérer les relations (One-to-Many, Many-to-Many, etc.)

    Pour utiliser EF Core avec MySQL, il faut installer les packages suivants via NuGet :
        1. Microsoft.EntityFrameworkCore
        2. Pomelo.EntityFrameworkCore.MySql
        3. Microsoft.EntityFrameworkCore.Tools
*/


Console.WriteLine("=== Demo Entity FrameWork ===");

// Nous devons instantier un AppDbContext pour ouvrir la connexion avec la BDD
using AppDbContext db = new AppDbContext();

// Avant de démarrer la migration (création de la structure de la BDD) 
// nous devons "commit" le changement dans la console NuGet :
// Outils > Gestionnaire de package Nuget > Console du gestionnaire de package

// La méthode Migrate permet de synchroniser nos tables avec notre BDD.
db.Database.Migrate();


/*
 *  CREATE 
 */

// Pour ajouter une personne en BDD, nous devons d'abord l'ajouter à la liste de dbContext. 
db.Personne.Add(new Personne("Toto", "Tata", 30, "0123456789", "test@test.com"));
// Puis SaveChanges permet de valider les modifications et envoie la requete à notre BDD. 
db.SaveChanges();

/*
 *  READ ALL 
 */

// On recupere toute la liste puis on l'affiche 
List<Personne> allPersonnes = db.Personne.ToList();

foreach (Personne p in allPersonnes)
    Console.WriteLine(p);

/*
 *  READ
 */

// Il y a plusieurs façon de récupérer un élément dans la liste

// Via sa place dans la table (ici le premier)
Personne? p1 = db.Personne.First();

// Via son ID
p1 = db.Personne.Find(p1.Id);

Console.WriteLine(p1);


/*
 *  UPDATE
 */

// Pour effectuer une mise à jour, nous devons d'abord récupérer l'élément en question (via FIND ou autre)
p1.Email = "unAutreTest@test.com";
p1.Age = 20;

// Une fois le changement effectué, nous devont appeler la méthode Update sur la liste. 
db.Personne.Update(p1);

// Et, comme pour l'ajout, sauvegarder les changements en BDD.
db.SaveChanges();

/*
 *  DELETE
 */

// Pour supprimer un élément, nous devons d'abord le récupérer puis utiliser la méthode Remove
db.Personne.Remove(p1);

// Enfin, nous devons sauvegarder les changements en BDD.
db.SaveChanges();

// OU 
db.Personne.Where(p => p.Age == 20).ExecuteDelete();


// TODO vider table
// db.Personne.;

/*
 * 
 * READ (avec des filtres) 
 *
*/

// Filtre WHERE + trie avec ORDER BY
List<Personne> adultTrie = db.Personne
    .Where(p => p.Age >= 18)
    .OrderBy(p => p.LastName)
    .ToList();

// Pagination
List<Personne> personnesPrecises = db.Personne
    .Skip(2)
    .Take(2)
    .ToList();

// Récupération de donnée précises
List<string> allName = db.Personne.Select(p => p.FirstName).ToList(); 

foreach(string name in allName)
{
    Console.WriteLine(name);
}