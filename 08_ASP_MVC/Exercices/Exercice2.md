# Exercice ASP.NET MVC : Gestion d'une liste de chiens

## Objectif
Créer une application ASP.NET MVC avec plusieurs endpoints permettant d’afficher des informations sur une liste de chiens à l’aide de vues Razor.

## Instructions

1. Créez un projet ASP.NET MVC.
2. Ajoutez un modèle `Dog` contenant les propriétés suivantes :
   - `Name`
   - `Age`
   - `Breed`
3. Ajoutez un contrôleur `DogController`.
4. Dans ce contrôleur, créez une liste de chiens initialisée en dur.
5. Implémentez les actions suivantes :

   - `Display(int id)`  
     - Retourne le chien correspondant à l’identifiant fourni.
     - Passe le chien à la vue via `ViewData`.
     - Si l’identifiant est invalide, redirige vers l’action `DisplayAll`.

   - `DisplayAll()`  
     - Passe la liste complète des chiens à la vue via `ViewData`.

   - `Greeting(string name)`  
     - Retourne un message de bienvenue.
     - Si un nom est fourni en query string, personnalise le message.
     - Passe le message à la vue via `ViewData`.

6. Créez une vue Razor pour chaque action :

   - `Display.cshtml` : affiche les informations d’un chien.
   - `DisplayAll.cshtml` : affiche la liste complète des chiens.
   - `Greeting.cshtml` : affiche le message de bienvenue.

## Routes suggérées

- `/Dog/Display/1`
- `/Dog/DisplayAll`
- `/Dog/Greeting`
- `/Dog/Greeting?name=Toto`
