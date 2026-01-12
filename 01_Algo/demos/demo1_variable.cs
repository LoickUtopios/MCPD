using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
		   // Commentaire sur une ligne
		   
		   /*
		      Commentaire
		      sur 
		      plusieurs
		      lignes
		   */ 
		   
		   /// Commentaire de documentations
		   
		   // affichage
		   Console.WriteLine("Hello World !");
		   Console.Write("Bonjour ");
		   Console.Write("Toto "); 
		   Console.Write("et à "); 
		   Console.Write("tout le monde !\n");
		   Console.WriteLine("Au revoir !");
		   
		   
		   // Déclaration de variable
		   // Nombre entier
		   short petitEntier;
		   int age;
		   long grandEntier;
		   
		   // Nombre décimaux
		   float nbAVirgule;
		   double nbAVirgulePrecis;
		   decimal nbAVirguleTresPrecis; 
		   
		   // Booléan
		   bool unBoolean;
		   
		   // Type de texte
		   char unCaractere;
		   string uneChaineDeCaractere;
		   
		   
		   // Affectation
		   age = 30; 
		   nbAVirgule = 12.5f;
		   unCaractere = 't'; 
		   uneChaineDeCaractere = "C'est une chaine de caractere.";
		   
		   // Déclaration et affectation 
		   string email = "mon email est \"test@test.com\"";
		   
		   Console.WriteLine(email);
		   
		   // Concaténation
		   // Ce principe permet de réunir plusieurs informations en une seule chaine de caracteres.
		   Console.WriteLine("Vous avez " + age + " ans.");
		   
		   Console.WriteLine("Affichage d'une variable : " + nbAVirgule); 
		   Console.WriteLine("Affichage d'une variable : " + unCaractere.GetType()); 
		   
		   string chaine1 = "Hello ";
		   string chaine2 = "World !"; 
		   Console.WriteLine(chaine1 + chaine2); 
		   
		   // Interpolation
		   Console.WriteLine($"Affichage d'une variable directement dans une chaine : {age}");
		   
		}
	}
}