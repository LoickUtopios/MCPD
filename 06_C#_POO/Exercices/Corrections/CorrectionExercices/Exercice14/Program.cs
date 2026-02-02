using Exercice14.Classes;

Adresse adresse1 = new Adresse(10, "Rue Victor Hugo", "Lille", "59000"); 
Adresse adresse2 = new Adresse(227, "Rue Backer Street", "Londre", "12345");

User user = new User("Toto", "Titi", adresse1);
User user2 = new User("Holmes", "Sherlock", adresse2); 

Lettre lettre = new Lettre(user, user2, "Bonjour Sherlock, avez-vous retrouvé mes chaussettes ?");

Console.WriteLine(lettre);

lettre.Envoyer();

Console.WriteLine(lettre);

lettre.Lire();

Console.WriteLine(lettre);