
using CorrectionsExercicesEF2.DbManager;
using CorrectionsExercicesEF2.Enum;
using CorrectionsExercicesEF2.Models;
using Microsoft.EntityFrameworkCore;

using AppDbContext db = new AppDbContext();
db.Database.Migrate();

void InitDb()
{
    db.Clients.Add(new Client("De Rives", "Geralt", "0123456789")); 
    db.Clients.Add(new Client("Dandelion", "Jasquier", "0123456789")); 
    db.Clients.Add(new Client("De Vengerberg", "Yennefer", "0123456789")); 
    db.Clients.Add(new Client("Merigold", "Triss", "0123456789")); 
    db.Clients.Add(new Client("De Vrie", "Tissaia", "0123456789"));

    db.Chambres.Add(new Chambre(100, StatutChambre.LIBRE, 2, 50.0));
    db.Chambres.Add(new Chambre(101, StatutChambre.EN_NETTOYAGE, 4, 150.0));
    db.Chambres.Add(new Chambre(102, StatutChambre.LIBRE, 4, 150.0));

    db.Chambres.Add(new Chambre(200, StatutChambre.LIBRE, 2, 70.0));
    db.Chambres.Add(new Chambre(201, StatutChambre.LIBRE, 6, 1500.0));
    db.Chambres.Add(new Chambre(202, StatutChambre.LIBRE, 2, 90.0));
    db.SaveChanges();
}

void AjouterUnClient()
{
    Console.WriteLine("=== Ajout d'un client ==="); 
    Console.WriteLine("Nom : ");
    string nom = Console.ReadLine();

    Console.WriteLine("Prenom : ");
    string prenom = Console.ReadLine();

    Console.WriteLine("Telephone : ");
    string telephone = Console.ReadLine();

    db.Clients.Add(new Client(nom, prenom, telephone));
    db.SaveChanges(); 
}

void AfficherLesClients()
{
    Console.WriteLine("=== Liste des clients ===");

    List<Client> allClients = db.Clients.OrderBy(c => c.Nom).ToList();

    foreach(Client client in allClients)
    {
        Console.WriteLine(client);
    }

    // allClients.ForEach(Console.WriteLine);
}

void AfficherLesReservationClient()
{
    Console.WriteLine("Veuillez donner l'id du client : ");
    int.TryParse(Console.ReadLine(), out int id);

    List<Reservation> allReservation = db.Reservations
                                            .Where(r => r.ClientId == id)
                                            .Include(r => r.Client)
                                            .Include(r => r.Chambre)
                                            .ToList();

    if (allReservation == null || allReservation.Count == 0)
    {
        Console.WriteLine("Aucune réservation pour le client concerné...");
        return;
    }

    Console.WriteLine("=== Client ===");
    Console.WriteLine(allReservation.First().Client);

    foreach (Reservation reservation in allReservation)
    {
        Console.WriteLine("Statut de la réservation : " + reservation.StatutReservation);
        Console.WriteLine("Chambres : ");
        Console.WriteLine(reservation.Chambre);
    }
}

void AjouterReservation()
{
    Reservation r = new Reservation();

    r.StatutReservation = StatutReservation.PREVU;

    Console.WriteLine("Veuillez donner un numéro de chambre : "); 
    r.ChambreId = int.Parse(Console.ReadLine());

    Console.WriteLine("Veuillez donner l'id du client : ");
    r.ClientId = int.Parse(Console.ReadLine());

    db.Reservations.Add(r);
    db.SaveChanges();
}

void AnnulerReservation()
{
    Console.WriteLine("Veuillez donner l'id de la réservation : ");
    int.TryParse(Console.ReadLine(), out int id);

    Reservation? reservation = db.Reservations.Where(r => r.Id == id).FirstOrDefault();

    if (reservation == null)
    {
        Console.WriteLine("Id inconnue pour cette réservation");
        return ;
    }

    reservation.StatutReservation = StatutReservation.ANNULE;

    db.Reservations.Update(reservation);
    db.SaveChanges();
}

void AfficherLesReservation()
{
    var r = db.Reservations
        .Include(r => r.Chambre)
        .Include(r => r.Client)
        .OrderBy(r => r.Id)
        .ToList();

    if (!r.Any())
    {
        Console.WriteLine("Aucune réservation en cours");
        return;
    }

    foreach(Reservation reservation in r)
    {
        Console.WriteLine(reservation); 
    }
}

void AfficherMenu()
{
    Console.WriteLine("""
        === Menu Principal ===

        1. Ajouter un client
        2. Afficher la liste des clients
        3. Afficher les réservations d'un client
        4. Ajouter une réservation
        5. Annuler une réservation
        6. Afficher la liste des réservations
        0. Quitter
        """);
}

// InitDb();
int choix = 0; 
do
{
    AfficherMenu();

    Console.WriteLine("Votre choix : ");
    int.TryParse(Console.ReadLine(), out choix);

    switch (choix)
    {
        case 0:
            Console.WriteLine("Au revoir ! o/");
            break;
        case 1:
            AjouterUnClient();
            break;
        case 2:
            AfficherLesClients();
            break;
        case 3:
            AfficherLesReservationClient();
            break;
        case 4:
            AjouterReservation();
            break;
        case 5:
            AnnulerReservation();
            break;
        case 6:
            AfficherLesReservation();
            break;
        default:
            Console.WriteLine("Choix invalide !");
            break;
    }

    Console.WriteLine("-- Press ENTER to continue --");
    Console.ReadLine();
    Console.Clear();

} while (choix != 0);

