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
		    int age = 18;
		    
		    // Si
		    // Les accolades sont optionnelles SI elle ne possède qu'une seule
		    // instructions.
		    if(age >= 18)
		      Console.WriteLine("Vous êtes majeur.");
		    
		    // Si...sinon
		    if(age < 18){
		      Console.WriteLine("Vous êtes mineur.");
		    }
		    else {
		      Console.WriteLine("Vous êtes majeur.");
		    }
		    
		    // Si....Sinon si....Sinon
		    if(age >= 0 && age < 15){
		      Console.WriteLine("Vous êtes mineur.");
		    } 
		    else if(age >= 15 && age < 18){
		      Console.WriteLine("Vous êtes adolescent.");
		    }
		    else if(age >= 18 && age < 25){
		      Console.WriteLine("Vous êtes un jeune homme.");
		    }
		    else {
		      Console.WriteLine("Vous êtes quelqu'un de sage.");
		    }
		    
		    
		    // Conditions imbriqués
		    float temperature = 25.3f;
		    
		    if(temperature < 0){
		      Console.WriteLine("Il fait froid ^^'"); 		    
		    }
		    else {
		      if(temperature < 10){
		        Console.WriteLine("Il fait frais.."); 	
		      } 
		      else if (temperature < 20){
		        Console.WriteLine("Il fait bon !!"); 
		      } 
		      else {
		        Console.WriteLine("Il fait chaud."); 
		      }
		    }
		       
		}
	}
}