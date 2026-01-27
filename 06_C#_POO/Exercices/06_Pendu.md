# POO - statiques : Pendu

**Exercice :** Pendu

1. Réaliser un jeu du pendu en créant une classe `Pendu` qui possédera au minimum comme attributs : 
- le masque
- le nombre d’essais
- le mot à trouver

Cette classe aura comme méthodes :
- TestChar()
- TestWin()
- GenererMasque()

2. Le joueur aura par défaut 10 chances pour gagner.

3. Utiliser une autre classe servant à générer les mots pour le jeu, à partir d’un tableau d’entrées potentielles.

4. Optionnellement, le joueur pourra choisir un nombre de coups pour sa partie.

5. Créer une IHM pour tester l'application.

exemple : 

```text
=== Paramètres de partie ===
Voulez vous un nombre d'essais spécifique (10 par défaut) ? Y/n Y
Combien voulez-vous d'essais : 15
Le mot à trouver : *********
Il vous reste 15 essais

Veuillez saisir un lettre : G 
Le mot à trouver : *********
Il vous reste 14 essais

Veuillez saisir un lettre : O
Le mot à trouver : ******O**
Il vous reste 14 essais
```
