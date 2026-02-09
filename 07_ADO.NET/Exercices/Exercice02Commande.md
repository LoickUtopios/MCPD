# Commande

## Objectif
L'objectif de cet exercice est d'apprendre à se connecter à une base de données, à récupérer des données depuis deux tables différentes, à les joindre et à les afficher à l'utilisateur.

## Sujet

Vous devez créer une application de gestion des commandes qui permet de visualiser et de modifier les informations des commandes et des clients. La base de données contient deux tables :

- Table Client :
  - ID : identifiant unique du client (entier)
  - Nom : nom du client (chaîne de caractères)
  - Prénom : prénom du client (chaîne de caractères)
  - Adresse : adresse du client (chaîne de caractères)
  - Code postal : code postal du client (chaîne de caractères)
  - Ville : ville du client (chaîne de caractères)
  - Téléphone : numéro de téléphone du client (chaîne de caractères)

- Table Commandes :
  - ID : identifiant unique de la commande (entier)
  - Client ID : identifiant du client associé à la commande (entier)
  - Date : date de la commande (date)
  - Total : montant total de la commande (nombre décimal)

1. Créer une méthode qui permet d'afficher tous les clients
2. Créer une méthode qui permet d'ajouter un client
3. Créer une méthode qui permet d'éditer un client
4. Créer une méthode qui permet de supprimer un client (et ses commandes)
5. Créer une méthode pour afficher le détail d'un client avec ses commandes
6. Créer une méthode qui permet d'ajouter une commande à un client

## Bonus
Créer une Interface Homme Machine pour tester votre application

```
   ____                                          _           
  / ___|___  _ __ ___  _ __ ___   __ _ _ __   __| | ___  ___ 
 | |   / _ \| '_ ` _ \| '_ ` _ \ / _` | '_ \ / _` |/ _ \/ __|
 | |__| (_) | | | | | | | | | | | (_| | | | | (_| |  __/\__ \
  \____\___/|_| |_| |_|_| |_| |_|\__,_|_| |_|\__,_|\___||___/

1. Afficher les clients
2. Créer un client
3. Modifier un client
4. Supprimer un client
5. Afficher les détails d'un client
6. Ajouter une commande
7. Modifier une commande
8. Supprimer une commande
0. Quitter
```