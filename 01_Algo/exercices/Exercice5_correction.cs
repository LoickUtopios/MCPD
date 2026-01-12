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
		    int nbPhotocopie = 30;
		    const float prixBas = 0.3f;
		    const float prixMoyen = 0.4f;
		    const float prixHaut = 0.5f; 
		    
		    if (nbPhotocopie <= 0){
		      Console.WriteLine("Erreur, nombre de photocopie incorrect");
		    } else if (nbPhotocopie < 10){
		      Console.WriteLine(nbPhotocopie * prixHaut);
		    } else if (nbPhotocopie >= 10 && nbPhotocopie <= 20){
		      Console.WriteLine(nbPhotocopie * prixMoyen);
		    } else {
		      Console.WriteLine(nbPhotocopie * prixBas);
		    }
		    
		}
	}
}