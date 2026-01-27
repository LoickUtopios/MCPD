//# POO: Création d'une chaise

//**Exercice :**
//1.Créer une classe `Chaise` possédant comme variables d’instance :
//-le nombre de pieds
//- le matériaux 
//- la couleur de l’objet

//2. Afficher ses informations en surchargeant une méthode de la classe Object (ToString).

//3. La classe `Chaise` pourra être instanciée avec ou sans paramètres (Constructeur par défaut)

//4. Afficher toutes les chaises

using Exercice1.Classes;

Chaise ch1 = new Chaise();
Chaise ch2 = new Chaise(5, "Acier", "Noir");

Console.WriteLine(ch1); 
Console.WriteLine(ch2.ToString()); 