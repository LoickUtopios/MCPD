double capital = 20_000.0;
double taux = 4 / 100.0;
int annee = 0;

double nouveauCapital = capital; 

while (nouveauCapital < capital * 2)
{
    annee++;
    nouveauCapital = capital * Math.Pow(1 + taux, annee); 
}

Console.WriteLine("Votre nouveau capital est de : " + nouveauCapital);
Console.WriteLine("Vous devez attendre " + annee + " ans, pour avoir le double de votre capital."); 
