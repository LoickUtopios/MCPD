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
		  // Opérateurs arithmétiques
		  Console.WriteLine(5 + 5); 
		  Console.WriteLine(5 - 5);
		  Console.WriteLine(5 * 5);
		  Console.WriteLine(5 / 5);
		  
		  Console.WriteLine(7 % 5); // Module : reste d'une division euclidienne
		  
		  // Opérateur d'affectation
		  int unEntier = 1;
		  unEntier = unEntier + 1;
		  unEntier += 5; // équivalent à : unEntier = unEntier + 5; 
		  
		  unEntier -= 3;
		  unEntier *= 2;
		  unEntier /= 4;
		  
		  Console.WriteLine(unEntier);
		  
		  string uneChaine = "Hello ";
		  uneChaine += "World !";
		  Console.WriteLine(uneChaine);
		  
		  // Opérateurs d'incrémentation
		  int compteur = 0;
		  compteur++; // Equivaut à : compteur = compteur + 1
		  Console.WriteLine(compteur); 
		  
		  compteur--;
		  Console.WriteLine(compteur); 
		  
		  // Opérateur d'expressions
		  Console.WriteLine(1 == 1); // True
		  Console.WriteLine(1 == 3);// False
		  
		  Console.WriteLine(3 >= 3); // True 
		  Console.WriteLine(3 > 3); // False
		  Console.WriteLine(5 < 5); // false
		  Console.WriteLine(5 <= 5); // True
		  Console.WriteLine(5 != 5); // False
		  
		  
		  // Opérateur logique
		  // OU
		  bool resultat = true || false; 
		  Console.WriteLine(resultat); // True
		  
		  // ET
		  resultat = true && false; 
		  Console.WriteLine(resultat); // False
		  
		  // NON
		  resultat = !false; 
		  Console.WriteLine(resultat); // True
		}
	}
}