# Gestion de courrier (POO)

## Sujet

1. Créer une classe **Adresse** possédant les attributs suivants :

   * **numeroRue : int**
   * **nomRue : string**
   * **ville : string**
   * **codePostal : string**
     ainsi qu’une méthode **ToString()** permettant d’afficher l’adresse complète.

2. Créer une classe **User** possédant les attributs suivants :

   * **nom : string**
   * **prenom : string**
   * **adresse : Adresse**
     La classe devra également implémenter une méthode **ToString()**.

3. (Optionnel) Créer une énumération **StatutLettre** contenant les différents états possibles d’une lettre
   (exemples : *EnAttente, Envoyee, Recue, Lue*).

4. Créer une classe **Lettre** possédant les attributs suivants :

   * **expediteur : User**
   * **destinataire : User**
   * **contenu : string**
   * **statut : StatutLettre ou string**

5. La classe **Lettre** devra contenir :

   * une méthode **Envoyer()** modifiant le statut de la lettre
   * une méthode **Lire()** modifiant le statut de la lettre
   * une méthode **ToString()** affichant toutes les informations de la lettre (expéditeur, destinataire, contenu, statut).

6. Mettre en place une **IHM** permettant :

   * de créer des utilisateurs
   * de rédiger une lettre
   * d’envoyer et de lire une lettre
   * d’afficher les informations complètes d’une lettre