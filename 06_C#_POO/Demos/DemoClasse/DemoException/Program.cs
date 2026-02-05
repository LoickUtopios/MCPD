
using DemoException.Classes;
using DemoException.Exceptions;

void AfficherUser(User user)
{
    if (user.Id < 0)
        throw new ArgumentOutOfRangeException("L'id ne peut pas être négatif !!!");

    if (user.Age < 0 || user.Age > 120)
        throw new AgeInvalidException("L'age doit être entre 0 et 120 !");

    Console.WriteLine($"{user.Id} - {user.Nom} {user.Prenom} {user.Age}");  
}

try
{
    AfficherUser(new User(1, "Toto", "Tata", 5));
    AfficherUser(new User(3, "Toto", "Tata", 200)); // AgeInvalidException
    //AfficherUser(new User(-5, "Toto", "Tata")); // ArgumentOutOfRangeException
    //AfficherUser(null); // NullReferenceException
}
catch(NullReferenceException e)
{
    Console.WriteLine("User null : " + e.Message);
}
catch(ArgumentOutOfRangeException e)
{
    Console.WriteLine("User id négatif :" + e.Message);
}
catch(AgeInvalidException e)
{
    Console.WriteLine(e);
}
catch(Exception e) // Exception est la classe parent (elle va attraper toutes les exceptions possibles)
{
    Console.WriteLine("Vous avez à autre type d'exceptions"); 
}
finally
{
    Console.WriteLine("Je m'affiche dans tout les cas (exception ou pas)."); 
}

Console.WriteLine("Finis !!"); 
