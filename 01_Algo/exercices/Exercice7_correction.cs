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
		    int age = 20;
		    
		    if (age < 3){
		      Console.WriteLine("Votre enfant est trop jeune !");
		    } else if (age >= 3 && age <= 6){
		      Console.WriteLine("Votre enfant est en catégorie 'Baby'.");
		    } else if (age >= 7 && age <= 8){
		      Console.WriteLine("Votre enfant est en catégorie 'Poussin'.");
		    } else if (age >= 9 && age <= 10){
		      Console.WriteLine("Votre enfant est en catégorie 'Pupille'.");
		    } else if (age >= 11 && age <= 12){
		      Console.WriteLine("Votre enfant est en catégorie 'Minime'.");
		    } else if (age >= 13 && age < 18){
		      Console.WriteLine("Votre enfant est en catégorie 'Cadet'.");
		    } else {
		      Console.WriteLine("Votre enfant est trop agé !");
		    }
		    
		    
		    // switch(age){
		    //   case 3:
		    //   case 4:
		    //   case 5:
		    //   case 6:
		    //     Console.WriteLine("Votre enfant est en catégorie 'Baby'.");
		    //     break;
		    //   case 7:
		    //   case 8: 
		    //     Console.WriteLine("Votre enfant est en catégorie 'Poussin'.");
		    //     break;
		    //   case 9: 
		    //   case 10:
		    //     Console.WriteLine("Votre enfant est en catégorie 'Pupille'.");
		    //     break;
		    //   case 11: 
		    //   case 12:
		    //     Console.WriteLine("Votre enfant est en catégorie 'Minime'.");
		    //     break;
		    //   case 13:
		    //   case 14:
		    //   case 15:
		    //   case 16:
		    //   case 17:
		    //   case 18:
      //       Console.WriteLine("Votre enfant est en catégorie 'Cadet'.");
      //       break;
      //     default:
      //       Console.WriteLine("Votre enfant est hors catégorie !");
      //       break; 
		    // }
		  
		    
		}
	}
}