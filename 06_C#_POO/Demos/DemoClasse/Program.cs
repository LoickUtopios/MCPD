using DemoClasse.Classes;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Afficher une variable de classe
            Voiture.AfficherNbVoiture(); 


            // Instantiation d'un objet (avec le constructeur par défaut)
            Voiture v = new Voiture();

            // Instantiation via un autre constructeur 
            Voiture v1 = new Voiture(4, 5, "Mercedes", "Classe 1");
            v1._nbPneu = 3; // Modification d'un attribut publique
            v1.Model = "ClassA"; // Modification d'un attribut via sa propriété (set)

            double puissance = Math.Pow(5, 2);

            // Affichage

            Console.WriteLine(v1.Model); // On utilise le get de la propriété
            Console.WriteLine(v1._nbPneu); // On affiche directement l'attribut (possible car elle est publique)

            // Appel d'une méthode
            v1.StartEngine();
            v1.StartEngine();

            Voiture v2 = new Voiture(4, 3, "Chevrolet", "Aveo");
            v2.StartEngine();

            Console.WriteLine(v2.ToString()); // Affichage par défaut de notre objet
            Console.WriteLine(v2); // Façon plus concise (appel directement ToString)

            Voiture.Presentation(v2.Model); 

            Voiture.AfficherNbVoiture();
        }
    }
}