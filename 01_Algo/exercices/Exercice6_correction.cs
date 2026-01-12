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
		    double capital = 10000;
		    double taux = 4 / 100.0; 
		    int nbAnnee = 5;
		    
		    double nouveauCapital = capital * Math.Pow((1 + taux),5); 
		    // nouveauCapital = Math.Round(nouveauCapital); // permet d'arrondir
		    
		    Console.WriteLine("Votre nouveau capital est de : " + nouveauCapital);
		    Console.WriteLine("Votre bénéfice est de : " + (nouveauCapital - capital));
		    
		}
	}
}