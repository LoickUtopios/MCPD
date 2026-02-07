# Étudiant

## Objectif
L'objectif de cet exercice est d'apprendre à se connecter à une base de données et à récupérer des données en utilisant ADO.NET.

## Sujet

Vous devez créer une application de gestion des étudiants qui permet de visualiser et de modifier leurs informations. La base de données contient une table nommée "etudiant" avec les colonnes suivantes :

- ID : identifiant unique de l'étudiant (entier)
- Nom : nom de l'étudiant (chaîne de caractères)
- Prénom : prénom de l'étudiant (chaîne de caractères)
- Date de naissance : date de naissance de l'étudiant (date)
- Adresse email : adresse e-mail de l'étudiant (chaîne de caractères)

1. Créer une méthode qui permet d'afficher tous les étudiants
2. Créer une méthode qui permet d'ajouter un étudiant
3. Créer une méthode qui permet d'éditer un étudiant
4. Créer une méthode qui permet de supprimer un étudiant

## Bonus

Pour aller plus loin, vous pouvez implémenter les fonctionnalités suivantes :
- Ajouter une validation des champs pour éviter les données invalides
- Ajouter une méthode de recherche pour permettre à l'utilisateur de chercher un étudiant en fonction de son nom ou de son prénom
- Créer une IHM pour tester le programme 

```
       _             _ _             _       
   ___| |_ _   _  __| (_) __ _ _ __ | |_ ___ 
  / _ \ __| | | |/ _` | |/ _` | '_ \| __/ __|
 |  __/ |_| |_| | (_| | | (_| | | | | |_\__ \
  \___|\__|\__,_|\__,_|_|\__,_|_| |_|\__|___/

1. Voir tous les étudiants
2. Ajouter un étudiant
3. Modifier un étudiant
4. Supprimer un étudiant
0. Quitter
```