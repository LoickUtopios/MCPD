# Personnages – Abstraction & Interfaces (POO)

## Sujet

1. Créer une classe **abstraite Personnage** possédant les attributs suivants :

   * **nom : string**
   * **prenom : string**
   * **pv : int**
   * **damage : int**

   La classe **Personnage** contiendra également :

   * une méthode abstraite **Attaquer(Personnage cible)**
   * une méthode **ToString()** permettant d’afficher les informations du personnage.

2. Créer une classe **Arme** possédant les attributs suivants :

   * **nom : string**
   * **degatSupplementaire : int**
   * **durabilite : int**

   La classe **Arme** contiendra une méthode **Utiliser()** diminuant la durabilité de l’arme à chaque attaque.

3. Créer une interface **IAttaqueSpeciale** contenant la méthode :

   * **AttaqueSpeciale(Personnage cible)**

4. Créer une interface **IMagie** contenant la méthode :

   * **LancerSort(Personnage cible)**

5. Créer une classe **Guerrier** héritant de **Personnage** et implémentant l’interface **IAttaqueSpeciale**.

   * Le **Guerrier** possède une **Arme**
   * Il implémente l’attaque spéciale propre au guerrier

6. Créer une classe **Mage** héritant de **Personnage** et implémentant l’interface **IMagie**.

   * Le **Mage** possède une **Arme**
   * Il peut lancer des sorts via l’interface **IMagie**

7. Créer une classe **GuerrierMage** héritant de **Personnage** et implémentant **IAttaqueSpeciale** et **IMagie**.

   * Cette classe possède toutes les actions du **Guerrier** et du **Mage**
   * Elle utilise une **Arme**
   * Elle peut à la fois lancer des sorts et effectuer des attaques spéciales

8. Chaque personnage devra :

   * utiliser son **Arme** lors d’une attaque
   * perdre des **pv** lorsqu’il subit une attaque
   * voir la durabilité de son arme diminuer à chaque utilisation

9. Réaliser une **IHM** ou un programme de test permettant :

   * de créer différents personnages
   * de les faire attaquer entre eux
   * d’afficher l’évolution des points de vie et de la durabilité des armes