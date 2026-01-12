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
		    int AB, BC, AC; 
		    AB = 5;
		    BC = 5;
		    AC = 5;
		    
		    if(AB == BC && AC == BC){
		      Console.WriteLine("Le triangle est équilatéral.");
		    }
		    else{
		      if(AB == AC && AC != BC){
		        Console.WriteLine("Le triange est isocèle en A.");
		      }
		      
		      if(AB == BC && AC != BC){
		        Console.WriteLine("Le triange est isocèle en B.");
		      }
		      
		      if(AC == BC && AB != BC){
		        Console.WriteLine("Le triange est isocèle en C.");
		      }
		      
		      if(AB != AC && AC != BC && AB != BC){
		        Console.WriteLine("Le triangle n'est isocele ni en A, ni en B, ni en C.");
		      }
		    }
		    
		    // Méthode 2 
		    
		    if(AB == BC){
		      if(AC == BC)
		        Console.WriteLine("Le triangle est équilatéral.");
		      else
		        Console.WriteLine("Le triangle est isocèle en B.");
		    }
		    else if(AB == AC){
	        Console.WriteLine("Le triangle est isocèle en A.");
	      } 
	      else if(AC == BC){
	        Console.WriteLine("Le triange est isocèle en C.");
	      }
		    else {
		      Console.WriteLine("Le triangle n'est isocele ni en A, ni en B, ni en C.");
		    }

		    
		}
	}
}