
# Exercice : Manipulation DML avec relation One-to-Many

Vous travaillez sur une base de données destinée à gérer les services d’une entreprise et leurs employés.
La base contient deux tables :

## 1. Création des tables

Créez les tables suivantes (les contraintes sont indiquées) :

### Table services

* service_id (clé primaire)
* libelle (texte, NOT NULL)
* date_creation (date, valeur par défaut : date du jour)

### Table employes

* employe_id (clé primaire)
* nom (texte, NOT NULL)
* prenom (texte)
* service_id (clé étrangère référençant *services.service_id*)

Relation :
Un service peut avoir plusieurs employés (**One-to-Many**).


## 2. Manipulations DML sur services

Effectuez les opérations suivantes :

### a) Insertions

1. Ajouter un service : **"Informatique"**
2. Ajouter un service : **"Ressources Humaines"**, créé le **2024-01-01**
3. Ajouter un service : **"Marketing"**

### b) Mises à jour

1. Modifier le libellé du service "Informatique" en **"IT"**
2. Mettre à jour la date de création du service "Ressources Humaines" avec la date du jour

### c) Suppressions

1. Supprimer le service "Marketing"
2. Supprimer **tous** les services dont la date de création est antérieure au **2024-01-01**

## 3. Manipulations DML sur employes

Après les opérations précédentes, insérez des employés rattachés à un service.

### a) Insertions

Insérez les employés suivants (en utilisant la clé étrangère `service_id`) :

| Nom     | Prénom | Service             |
| ------- | ------ | ------------------- |
| Martin  | Paul   | IT                  |
| Dupont  | Claire | IT                  |
| Bernard | Sophie | Ressources Humaines |

*(Vous devrez récupérer les `service_id` correspondant.)*

### b) Mise à jour

Modifier le nom **Martin** → **Martinez**

### c) Suppression

Supprimer l’employé dont le prénom est **Claire**.

---

## 4. Résultat final

Afficher :

1. Tous les services encore présents
2. Tous les employés encore présents