# Exercice : Manipulation des données dans une View Razor

## Objectif
Créer une application ASP.NET MVC avec l’utilisation des variables, conditions et boucles dans une vue Razor.

## Instructions

1. Créez un projet ASP.NET MVC.
2. Ajoutez un contrôleur `DisplayController`.
3. Dans ce contrôleur, créez une action `Index()` qui :

   - Définit une variable `string` contenant un prénom.
   - Définit une variable `int` contenant un âge.
   - Définit une liste de chaînes de caractères représentant des hobbies.
   - Passe toutes ces informations à la vue via `ViewData`.

4. Créez une vue Razor `Index.cshtml`.

5. Dans la vue, implémentez les éléments suivants :

   - Affichez le prénom et l’âge.
   - Utilisez une condition :
     - Si l’âge est supérieur ou égal à 18, afficher "Majeur".
     - Sinon, afficher "Mineur".
   - Utilisez une boucle pour afficher la liste des hobbies sous forme de liste HTML (`<ul>` / `<li>`).
   - Ajoutez une condition supplémentaire :
     - Si la liste des hobbies est vide, afficher "Aucun hobby renseigné".

## Route suggérée

- `/Display/Index`

## Exemple de rendu attendu

Nom : Toto  
Âge : 20  
Statut : Majeur  

Hobbies :
- Lecture  
- Sport  
- Musique  

## Bonus

- Ajouter une boucle `for` qui affiche les nombres de 1 à 10.
- Afficher les nombres pairs en gras.
- Ajouter une feuille de style css pour changer la couleur de fond et la couleur de police pour chaque hobbies.