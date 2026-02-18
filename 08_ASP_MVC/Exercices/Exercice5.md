# Exercice : Gestion d’un formulaire de Produit

## Objectif

Créer une application ASP.NET MVC permettant :

- D’afficher un formulaire de Produit
- De valider les données saisies
- D’afficher les erreurs si le formulaire est invalide
- De rediriger vers une page de confirmation si le formulaire est valide

## Instructions

1. Créez un projet ASP.NET MVC

2. Ajouter un Modèle `Product` avec les champs suivants :

- Id (int)
- Name (string)
- Price (double)
- Category (string)

Ajoutez des --Data Annotations-- pour la validation :

- `Name` → obligatoire
- `Price` → obligatoire + supérieur à 0
- `Category` → obligatoire


3. Créez un contrôleur `ProductController`

Ajoutez les endpoints suivants :

- Endpoint pour afficher le formulaire (GET)
- Endpoint pour traiter le formulaire (POST)
  - Vérifie `ModelState.IsValid`
  - Si invalide → réaffiche la vue `Form` avec les erreurs
  - Si valide → redirige vers la page `Details`

- Endpoint pour afficher les détails soumis (GET)

4. Créez les vues appropriées

  - Vue `Form`

    Contient :

    - Un formulaire utilisant `@model Product`
    - Les champs :

      - Name
      - Price
      - Category
      
    - Affichage des erreurs avec :

      - `asp-validation-for`
      - `asp-validation-summary`

    Boutons :

    - Envoyer

- Vue `Details`

  Affiche :

  - Nom
  - Prix
  - Category

  Liens :
  - Retour au formulaire
