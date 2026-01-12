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
		    int poids = 72;
		    int taille = 178;
		    string resultat = "";
		    
		    // Cette condition permet de retirer toutes les valeurs hors tableaux
		    // Les '||' sont des OU logiques (si l'une des conditions est VRAI, l'ensemble est VRAI) 
		    if(poids < 43 || poids > 77 || taille < 145 || taille > 183){
		      resultat = "Taille non-disponible."; 
		    }
		    if(poids <= 47){
		      // Ligne 1 
		      // Je vérifie ma taille à partie de la gauche du tableau.
		      // Sur la première soit nous une taille 1 soit aucune taille. 
		      if(taille <= 169)
		        resultat = "Taille 1"; 
		      else
		        resultat = "Taille non-disponible.";
		    }
		    else if(poids <= 53){
		      // Ligne 2
		      // Sur la ligne 2, nous avons soit la taille 1, la taille 2 ou hors catégorie.
		      // Nous n'avons pas à préciser les valeurs inférieurs à 145 car elles ont déjà été retirer dans la premiere condition.
		      if(taille <= 166)
		        resultat = "Taille 1";
		      // De même que nous n'avons pas besoin de préciser que la taille doit être entre 167 et 178, car
		      // toutes les valeurs inférieurs à 167 ont déjà été vérifié dans la condtion précédente.
		      else if (taille <= 178)
		        resultat = "Taille 2"; 
		      else
		        resultat = "Taille non-disponible.";
		    }
		    else if(poids <= 59){
		      // Ligne 3
		      if(taille <= 163)
		        resultat = "Taille 1";
		      else if (taille <= 175)
		        resultat = "Taille 2";
		      else if (taille <= 183)
		        resultat = "Taille 3"; 
		      else // Ce else est inutile car toutes les valeurs hors-tableau ont déjà été prisent en comptent.
		        resultat = "Taille non-disponible.";
		    }
		    else if(poids <= 65){
		      // Ligne 4
		      if(taille <= 160)
		        resultat = "Taille 1";
		      else if (taille <= 172)
		        resultat = "Taille 2";
		      else if (taille <= 183)
		        resultat = "Taille 3"; 
		      else
		        resultat = "Taille non-disponible.";
		    }
		    else if(poids <= 71){
		      // Ligne 5
		      if(taille <= 157)
		        resultat = "Taille non-disponible.";
		      else if (taille <= 169)
		        resultat = "Taille 2";
		      else if (taille <= 183)
		        resultat = "Taille 3"; 
		      else
		        resultat = "Taille non-disponible.";
		    }
		    else {
		      // Ligne 6
		      if(taille <= 160)
		        resultat = "Taille non-disponible.";
		      else if (taille <= 183)
		        resultat = "Taille 3"; 
		      else
		        resultat = "Taille non-disponible.";
		    }
		    
		    Console.WriteLine(resultat); 

		    
		}
	}
}