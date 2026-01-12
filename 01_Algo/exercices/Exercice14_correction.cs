Console.Write("Veuillez saisir n : "); 
int saisie = int.Parse(Console.ReadLine());
int somme = 0;
string resultat = ""; 

for(int i = 1; i <= saisie; i++)
{
    somme = somme + i;
    // somme += i;

    // Cette partie est optionnel (uniquement pour l'affichage)
    if (i == saisie)
        resultat += i + " = ";
    else
        resultat += i + " + ";
}
Console.Write(resultat + somme);
