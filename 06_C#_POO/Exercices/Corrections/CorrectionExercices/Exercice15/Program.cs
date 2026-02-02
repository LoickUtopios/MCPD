using Exercice15.Classes;

Arme[] armurie = new Arme[5];
armurie[0] = new Arme("Spatule", 2, 100);
armurie[1] = new Arme("Baton très très magique", 10, 3);
armurie[2] = new Arme("Lame runique", 20, 5);
armurie[3] = new Arme("Vorpal", 30, 10);
armurie[4] = new Arme("L'hache du gros bourrin", 50, 2);

Random random = new Random();

Guerrier bob = new Guerrier("L'éponge", "Bob", 50, 10, armurie[random.Next(0, 5)]);
Guerrier patrick = new Guerrier("Etoile", "Patrick", 100, 2, armurie[random.Next(0, 5)]);
Mage carlo = new Mage("Tentacule", "Carlo", 20, 20, armurie[random.Next(0, 5)]);
Mage doby = new Mage("Chaussette", "Doby", 5, 40, armurie[random.Next(0, 5)]);
GuerrierMage shadow = new GuerrierMage("Shadow", "Shadow", 80, 50, armurie[random.Next(0, 5)]);

Personnage[] joueurs = {bob, patrick, carlo, doby, shadow};

Personnage p1 = joueurs[random.Next(0, 5)]; 
Personnage p2 = joueurs[random.Next(0, 5)];


void Jouer(Personnage attaquant, Personnage défenseur)
{
    if (attaquant is Guerrier guerrier)
        guerrier.AttaqueSpecial(défenseur);

    if (attaquant is Mage mage)
        mage.LancerSort(défenseur);

    if (attaquant is GuerrierMage gm)
    {
        if (random.Next(0, 1) == 0)
            gm.AttaqueSpecial(défenseur);
        else
            gm.LancerSort(défenseur);
    }
}

Console.WriteLine("Joueur 1 est : \n");
Console.WriteLine(p1);
Console.WriteLine(p1.Arme);
Console.WriteLine();

Console.WriteLine("Joueur 2 est :");
Console.WriteLine(p2);
Console.WriteLine(p2.Arme);
Console.WriteLine();


do
{
    Jouer(p1, p2);

    if (p2.PointDeVie <= 0)
        break;

    Jouer(p2, p1); 

} while (p1.PointDeVie > 0 && p2.PointDeVie > 0);


if (p1.PointDeVie > 0)
    Console.WriteLine($"Le vainqueur est : {p1.Nom.ToUpper()} !!!!!!");
else
    Console.WriteLine($"Le vainqueur est : {p2.Nom.ToUpper()} !!!!!!");