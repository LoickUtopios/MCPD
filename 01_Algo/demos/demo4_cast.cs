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
		   // Cast implicite (petit vers grand)
		   byte unOctet = 127;
		   short unShort = unOctet;
		   int unEntier = unShort;
		   long unLong = unEntier;
		   
		   Console.WriteLine("Valeur caster en long : " + unLong); 
		   
		   // Le cast fonctionne car double est plus grand que int 
		   // (on ajoute simplement un 0 après la virgule)
		   double unDecimal = unEntier; 
		   
		   Console.WriteLine("Valeur caster en double : " + unDecimal);
		   
		   
		   // Cast explicite 
		   // Ici, le cast est forcé et fonctionnera mais si la valeur est trop grande
		   // celle-ci sera tronqué.
		   int unAutreInt = 20_000;
		   short unAutreShort = (short) unAutreInt;
		  
		   Console.WriteLine("Valeur caster en short : " + unAutreShort);
		   
		   string ageStr = "30";
		   
		   int age = int.Parse(ageStr);
		  
		   Console.WriteLine("Chaine caster en entier : " + age);
		   
		}
	}
}