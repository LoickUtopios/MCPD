
//- Si au moins une note est inférieure à 0 ou supérieure à 20,
//la fonction doit lever une exception  `ArgumentOutOfRangeException`
//avec le message :
//"Les notes doivent être entre 0 et 20.".

using Exercice21.Exceptions;

double CalculMoyenne(int[] notes)
{
    if (notes == null || notes.Length == 0)
        throw new InvalidArrayException("Le tableau ne peut pas être vide ou null."); 

    int somme = 0;
    foreach(int note in notes)
    {
        if (note < 0 || note > 20)
            throw new ArgumentOutOfRangeException("La note doit être comprise entre 0 et 20.");

        somme += note;
    }

    return (float) somme / notes.Length;
}

int[] notes = { 0, 5, 12, 14, 19, 20 };

try
{
    Console.WriteLine("La moyenne des notes est de " + CalculMoyenne(notes));
} 
catch (InvalidArrayException e)
{
    Console.WriteLine("Erreur de tableau !"); 
    Console.WriteLine(e.Message);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Un soucis au niveau des notes !!");
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Mince, une exception vraiment imprévisible Oo");
    Console.WriteLine(e.Message);
}

Console.WriteLine("Le programme c'est terminé correctement \\o/");
