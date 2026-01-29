# Vehicule (interfaces)

**Exercice :** 

Créez une classe abstraite `Vehicule` représentant un véhicule. Elle aura deux propriétés :

- `nom` qui stocke le nom du véhicule.
- `marque` qui stocke la marque du véhicule.

La classe Vehicule possédera également une méthode `toString()` qui retourne une description du véhicule.

Ensuite, vous créerez plusieurs interfaces représentant des comportements spécifiques des véhicules :

- `Motorise` : un véhicule qui peut `démarrer()`.
- `Electrique` : un véhicule qui peut se `recharger()`.
- `Volant` : un véhicule qui peut `décoller()` et `atterrir()`.
- `Flottant` : un véhicule qui peut `naviguer()` sur l'eau.

Vous devez implémenter ces interfaces dans différentes classes (qui hériterons toutes de la classe `Vehicule`) et déclarer les méthodes correspondante. Voici les classes à créer :

- Voiture : un véhicule qui implémente l'interface Motorise.
- VoitureHybride : un véhicule qui implémente les interfaces Motorise et Electrique.
- Hydravion : un véhicule qui implémente les interfaces Motorise, Volant, et Flottant.

Enfin, créez des objets de chaque type de véhicule (Voiture, VoitureHybride, Hydravion) en leur donnant des noms et des marques, puis affichez les informations de chaque véhicule et effectuez les actions correspondantes (démarrer, recharger, décoller, etc.).