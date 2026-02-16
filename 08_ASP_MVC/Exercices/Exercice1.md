# Exercice 1 - ASP.NET MVC : Afficher un nombre aléatoire

## Objectif
Créer une application ASP.NET MVC avec une page Razor qui affiche un nombre aléatoire généré côté serveur.

## Instructions

1. Créez un nouveau projet ASP.NET MVC.
2. Ajoutez un contrôleur `RandomController`.
3. Dans ce contrôleur, créez une action `Index` qui :
   - Génère un nombre aléatoire entre 1 et 100.
   - Passe ce nombre à la vue via `ViewData`.
4. Créez une vue Razor `Index.cshtml` associée à l’action :
   - Affichez le nombre aléatoire reçu depuis `ViewData`.

### Exemple de sortie attendue

Le nombre aléatoire généré est : 42

### Bonus

- Ajouter un lien dans la page afin de la recharger et afficher un nouveau nombre.