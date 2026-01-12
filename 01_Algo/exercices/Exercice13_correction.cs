int saisie;
int max = 0;

for(int i = 0; i < 6; i++)
{
    Console.Write("Veuillez saisir un nombre : "); 
    saisie = int.Parse(Console.ReadLine());

    if (i == 0)
        max = saisie;
    else
    {
        if(saisie > max)
            max = saisie;
    }
}

Console.WriteLine("Le nombre maximum est " + max);