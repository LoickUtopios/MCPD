
using Exercice13.Classes;

Point p1 = new Point(0, 0);
Point p2 = new Point(5, 0);

Rectangle rec = new Rectangle("Rectangle", p1 , 5, 6); 
Carre car = new Carre("Carre", p2 , 4);
// Il est possible de ne pas stocker l'objet au préalable en envoyant directement l'objet instancier (avec le new) 
Triangle tri = new Triangle("Triangle", new Point(5, 5), 5, 10);


Console.WriteLine(rec); 
Console.WriteLine(car); 
Console.WriteLine(tri);

tri.Deplacement(-5, 5);
Console.WriteLine(tri);
