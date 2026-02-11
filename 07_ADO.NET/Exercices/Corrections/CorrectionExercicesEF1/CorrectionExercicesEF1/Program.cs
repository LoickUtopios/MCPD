using CorrectionExercicesEF1.Classes;
using CorrectionExercicesEF1.DbManager;
using Microsoft.EntityFrameworkCore;

AppDbContext db = new AppDbContext();
db.Database.Migrate(); 

void DisplayAllAdress(AppDbContext db)
{
    List<Adresse> adresses = db.Adresses.ToList();

    foreach (Adresse ad in adresses)
    {
        Console.WriteLine(ad);
    }
}

void AddAdress(AppDbContext db)
{
    Adresse adresse = SaisirAdresse();

    db.Add(adresse); 
    db.SaveChanges();
}

Adresse SaisirAdresse()
{
    Console.WriteLine("Veuillez saisir le numéro de voie SVP : ");
    int num = int.Parse(Console.ReadLine());

    Console.WriteLine("Veuillez saisir le complément d'adresse SVP :");
    string comp = Console.ReadLine();

    Console.WriteLine("Veuillez saisir l'intitulé de voie SVP : ");
    string intitule = Console.ReadLine();

    Console.WriteLine("Veuillez saisir la commune SVP : ");
    string commune = Console.ReadLine();

    Console.WriteLine("Veuillez saisir le code postal SVP : ");
    string cp = Console.ReadLine();

    return new Adresse(num, comp, intitule, commune, cp);
}

void UpdateAdress(AppDbContext db)
{
    DisplayAllAdress(db);

    Adresse? ad = GetAdressById();

    if (ad == null)
    {
        Console.WriteLine("Id introuvable !"); 
        return;
    }

    Adresse adresse = SaisirAdresse(); 

    ad.NumVoie = adresse.NumVoie;
    ad.Complement = adresse.Complement;
    ad.Intitule = adresse.Intitule;
    ad.Commune = adresse.Commune;
    ad.CodePostal = adresse.CodePostal;

    db.Adresses.Update(ad);
    db.SaveChanges();
}

Adresse? GetAdressById()
{
    Console.WriteLine("Veuillez saisir l'id de l'adresse à modifier : ");
    int id = int.Parse(Console.ReadLine());

    return db.Adresses.Find(id);
}

void RemoveAdress(AppDbContext db)
{
    DisplayAllAdress(db);

    Adresse? ad = GetAdressById();

    if (ad == null)
    {
        Console.WriteLine("Id introuvable !");
        return;
    }
    db.Adresses.Remove(ad);
    db.SaveChanges();
}


AddAdress(db);
DisplayAllAdress(db);
UpdateAdress(db);
RemoveAdress(db);