int habitantActuel = 96809;
double habitantCalculee = habitantActuel;
double taux = 0.89 / 100;
int nbAnnee = 0;

while (habitantCalculee < 120_000)
{
    nbAnnee++;
    habitantCalculee += habitantCalculee * taux;
}
Console.WriteLine(Math.Round(habitantCalculee));
Console.WriteLine("Pour atteindre 120000 habitants, il faut attendre " + nbAnnee + " ans.");
