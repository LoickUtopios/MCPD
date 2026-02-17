# Exercice : Application de gestion de produits

## Objectif
Vous allez créer une application ASP MVC simple pour gérer une liste de produits. 
L'application permettra de :
- Récupérer les détails d'un produit spécifique en utilisant une variable de chemin.
- Filtrer les produits en fonction de certains critères en utilisant des paramètres de requête.

## Instructions

1. Créez un projet ASP.NET MVC.
2. Ajouter un Modèle `Product` ayant les champs suivant :
  - id (int)
  - name (string)
  - category (string ou enum)
  - price (double)

2. Créez une classe `ProductService` qui gère la logique métier, incluant :
- une liste de produit initialisé 
- une méthode pour récupérer un produit par ID
- une méthode pour récupérer la liste de produit
- une méthode pour filtrer les produits

3. Ajoutez un contrôleur `ProductController`.

#### Les endpoints du controlleur appeleront les méthodes du service
4. Dans ce contrôleur, créez les endpoints suivants :
  - Endpoint pour afficher tous les produits
  - Endpoint pour récupérer et afficher un produit par ID
  - Endpoint pour filtrer et afficher les produits par catégorie et prix maximum

5. Créer les vues approprié pour chaque endpoint et afficher leur résultat via `@model` :