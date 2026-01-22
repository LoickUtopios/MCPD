
//## Exercice — Analyse d’un nombre (if imbriqués + if indépendants)

//### Sujet

//Demander un entier `n` (via `TryParse`).
//Si la saisie est invalide → `Entier invalide`.

//Sinon :

//1.Afficher s’il est `negatif`, `nul` ou `positif` (avec `if` imbriqués comme dans la démo).
//2. Puis afficher si `pair` ou `impair` (avec un `if / else` séparé).
//3. Enfin, afficher `Dans [-10;10]` si `n` est dans l’intervalle, sinon `Hors [-10;10]`.

using System.Formats.Asn1;

Console.WriteLine("Entrer un entier : ");
string? saisie = Console.ReadLine();

if(int.TryParse(saisie,out int n))
{
    if (n < 0)
        Console.WriteLine("Negatif");
    else if (n == 0)
        Console.WriteLine("Nul");
    else
        Console.WriteLine("Positif");

    if (n % 2 == 0) 
        Console.WriteLine("Pair");
    else
        Console.WriteLine("Impair");

    if (n >= -10 && n <= 10)
        Console.WriteLine("Dans [-10;10]");
    else
        Console.WriteLine("Hors [-10;10]"); 
}
else
{
    Console.WriteLine("Entier invalide");
}

