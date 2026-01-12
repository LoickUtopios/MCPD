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
            // Réponsé exercice 2
            // Sans variable intermédiaire ou calcul, la valeur de A va être écraser par la valeur de B. A sera perdu.

		  // Méthode 1
		  // int A;
		  // int B; 
		  // int C; 
		   
		  // A = 1;
		  // B = 2;
		   
		  // C = A;
		  // A = B;
		  // B = C; 
		  
		  // Méthode 2
		  
		   int A;
		   int B; 
		   
		   A = 1;
		   B = 2;
		   
		   A = A + B; // A = 3
		   B = A - B; // B = 1
		   A = A - B; // A = 2
		   
		   Console.WriteLine("La valeur de A est : " + A);
		   Console.WriteLine("La valeur de B est : " + B);
		}
	}
}