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
		    int nombre = 7;
		    
		    if(nombre % 3 == 0){
		      Console.WriteLine("Votre nombre est divisible par 3."); 
		    }
		    else {
		      Console.WriteLine("Votre nombre n'est pas divisible par 3.");
		    }
		}
	}
}