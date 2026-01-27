# POO - statiques : Chenil

**Exercice :** Créer une classe Chien permettant de gérer les chiens de notre chenil. 

La classe aura les attributs suivants : 
- nom (string)
- race (string)
- age (int)
- nomDuChenil (string, static) 
- nbChiens (int, static)

Elle aura également les méthodes suivantes : 
- Constructeur : initialise nom, race, age et incrémente nbChiens à la création d’un chien.

- Accesseurs (getters) et mutateurs (setters) pour les attributs non statiques (nom, race, age).

- toString() : retourne une description du chien (nom, race, âge et nom du chenil), en utilisant les getters.

Instructions : 

1. Instancier deux objets Chien avec des valeurs différentes.

2. Modifier les valeurs du premier chien via les setteurs.

3. Afficher les informations des deux chiens avec Console.WriteLine (grâce à toString()).

4. Modifier le nom du chenil (attribut statique).

5. Réafficher les informations des deux chiens pour voir que le nom du chenil a bien changé pour les deux.