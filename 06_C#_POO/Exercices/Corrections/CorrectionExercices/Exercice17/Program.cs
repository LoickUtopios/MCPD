//Un programme doit enregistrer des températures saisies par l’utilisateur.

//Règles :

//1.L’utilisateur saisit des températures une par une.
//2. La saisie s’arrête quand il entre `-999`.
//3. Les températures valides sont entre `-50` et `50`.
//4. Les valeurs valides sont stockées dans une `List<int>`.
//5. Les valeurs invalides sont comptées (mais non stockées).

//À la fin, afficher :

//*le nombre de valeurs valides
//* le nombre de valeurs invalides
//* la température minimale et maximale valides


float input;
List<float> temperatureValides = new List<float>();

int nbTemperatureInvalides = 0;

do
{
    Console.Write("Veuillez donner une temperature : ");
    if (float.TryParse(Console.ReadLine(), out input))
    {
        if(input == -999)
            break;
        else if(input >= -50 && input <= 50)
            temperatureValides.Add(input);
        else
            nbTemperatureInvalides++;
    }
    else
        nbTemperatureInvalides++;

} while (true);


Console.WriteLine("Le nombre de temperature valides : " + temperatureValides.Count);
Console.WriteLine("Le nombre de temperature invalides : " + nbTemperatureInvalides);

Console.WriteLine("La temparature max est de : " + temperatureValides.Max());
Console.WriteLine("La temparature min est de : " + temperatureValides.Min());

temperatureValides.Sort(); 

Console.WriteLine("La temparature max est de : " + temperatureValides[temperatureValides.Count - 1]);
Console.WriteLine("La temparature min est de : " + temperatureValides[0]);

