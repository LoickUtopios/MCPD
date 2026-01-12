int plusGrand(int nb1, int nb2)
{
    int resultat = 0;
    if(nb1 < nb2)
    {
        resultat = nb2;
    }
    else
    { 
        resultat = nb1; 
    }

    return resultat;

    /* Méthode 2 
        if(nb1 < nb2)
        {
            return nb2;
        }

        return nb1; 
    */
    
    // Méthode 3 (avec une ternaire)
    //return nb1 > nb2 ? nb1 : nb2;
}

Console.WriteLine("Veuillez enter un nombre 1 : "); 
int nb1 = int.Parse(Console.ReadLine());

Console.WriteLine("Veuillez enter un nombre 2 : ");
int nb2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Le nombre le plus grand entre {nb1} et {nb2} : {plusGrand(nb1,nb2)}");