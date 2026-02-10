# Recette

## Objectif
L'objectif de cet exercice est de vous apprendre à travailler avec des relations many-to-many en utilisant ADO.NET. Vous devrez créer une application de gestion de recettes de cuisines des ingrédients. La base de données contient deux tables et une table de relation.

## Sujet

Vous devez créer une application de gestion de recettes qui permet de visualiser et de modifier des recettes de cuisine. La base de données contient trois tables :
### Recette
| Colonne | Type de données | Contrainte |
| --- | --- | --- |
| recette_id | int | PRIMARY KEY |
| nom | varchar(50) | NOT NULL |
| description | varchar(200) | NOT NULL |
| instructions | varchar(MAX) | NOT NULL |

### Ingredient
| Colonne | Type de données | Contrainte |
| --- | --- | --- |
| ingredient_id | int | PRIMARY KEY |
| nom | varchar(50) | NOT NULL |
| description | varchar(200) | NOT NULL |

### RecetteIngredient
| Colonne | Type de données | Contrainte |
| --- | --- | --- |
| recette_id | int | FOREIGN KEY |
| ingredient_id | int | FOREIGN KEY |
| quantite | varchar(10) | NOT NULL |

1. Créer une méthode qui permet d'afficher toutes les recettes
2. Créer une méthode qui permet d'afficher les ingrédients
3. Créer une méthode qui permet d'ajouter une recette (ainsi que les ingrédients liés à cette recette)
4. Créer une méthode qui permet d'ajouter un ingrédient
5. Créer une méthode qui permet d'afficher une recette avec le détail des ingrédients
6. Créer une méthode pour supprimer une recette (supprimer également les ingrédients liés à la recette dans la table intermédiaire)

## Bonus
- Créer une Interface Homme Machine pour tester votre application
- Ajouter un point de menu pour afficher l'ingrédient le plus utilisé dans les recettes
- Ajouter un point de menu pour trouver la recette avec le plus d'ingrédients

```
  ____               _   _       
 |  _ \ ___  ___ ___| |_| |_ ___ 
 | |_) / _ \/ __/ _ \ __| __/ _ \
 |  _ <  __/ (_|  __/ |_| ||  __/
 |_| \_\___|\___\___|\__|\__\___|

1. Afficher les recettes
2. Afficher les ingrédients
3. Ajouter une recette
4. Ajouter un ingrédient
5. Afficher le détail d'une recette
6. Supprimer une recette
7. Afficher l'ingrédient le plus utilisé
8. Afficher la recette avec le plus d'ingrédients
0. Quitter
```