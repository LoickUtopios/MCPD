//# POO: Création d'un rectangle

//**Exercice :**Créer une classe `Rectangle` avec deux propriétés `largeur` et `hauteur`, 
//    et deux méthodes `perimetre()` et `surface()`. 

//    Créer ensuite un objet `monRectangle` à partir de cette classe,
//    définir ses propriétés `largeur` et `hauteur`, 
//    et appeler ses méthodes `perimetre()` et `surface()`.

using Exercice2.Classes;

Rectangle rectangle = new Rectangle(5, 7);
Console.WriteLine("La surface de mon rectangle est : " + rectangle.Perimetre());
Console.WriteLine("L'aire de mon rectangle est : " + rectangle.Surface());