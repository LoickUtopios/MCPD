# Exercice : Application de gestion de produits

## Objectif
On souhaite créer une application web qui va nous permettre de gérer des étudiants, c'est-à-dire :
- Créer un étudiant (nom, prénom, âge, email)
- Lister tous les étudiants

## Instructions

1. Créez un projet ASP.NET MVC.

2. Ajouter un Modèle `Student` ayant les champs suivant :
  - id (int)
  - firstname (string)
  - lastname (string)
  - age (int)
  - email (string)

3. Installer les plugins nécessaire à EntityFramework: 
  - Microsoft.EntityFrameworkCore v9
  - Microsoft.EntityFrameworkCore.Tools v9
  - Pomelo.EntityFrameworkCore.MySql

3bis. Démarrer le server SQL et créer une base de donnée `asp` 

4. Créer une classe `StudentDbContext` qui possèdera une `DbSet<Student>`.

5. Créez une classe `StudentRepository` qui injecte `StudentDbContext` et implémente une interface `IStudentRepository`. Elle possèdera :
- une méthode qui renvoie la totalisé de la liste. 
- une méthode qui ajoute un étudiant à la liste.

6. Créez une classe `StudentService` qui gère la logique métier, injecte `IStudentRepository`, implémente `IStudentService` et incluant :
- une méthode pour récupérer la liste des étudiants (renvoie `List<Student>`)
- une méthode pour ajouter un étudiant. 

7. Ajoutez un contrôleur `StudentController` qui injecte `IStudentService`.

Dans ce contrôleur, créez les endpoints suivants :
  - Endpoint pour afficher tous les étudiants
  - Endpoint pour afficher un formulaire permettant l'ajout d'un étudiant.
  - Endpoint (POST) pour vérifier les donnée et ajouter un étudiant (redirige vers la liste des étudiant). 

8. Ajouter la chaine de connection dans `appsettings.json` : 

```json
"ConnectionStrings": {
  "DefaultConnection" : "server=localhost;uid=root;pwd=;database=asp;"
}
```

9. Ajouter les injections de dépendances dans `Program.cs` : 

```csharp
builder.Services.AddDbContext<StudentDbContext>(options => 
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
        )
);
builder.Services.AddScoped<Interface, Classe>(); // 1 pour le repo et 1 pour le service
```

10. Créer les vues approprié pour chaque endpoint et afficher leur résultat via `@model` :
- Liste des étudiants
- Inscription

Sur la page `Liste des étudiants` :
  - Afficher les informations de chaque étudiant

Sur la page `Inscription`, il sera possible de :
  - remplir un formulaire et être redirigé vers la page liste des étudiants
  - revenir à la liste des étudiants