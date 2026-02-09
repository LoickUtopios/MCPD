using CorrectionExercices1.Class.Exceptions;
using CorrectionExercices1.Class.Model;
using CorrectionExercices1.Class.Repository;
using System.Collections.Generic;



DateTime SaisieDateDeNaissance()
{
    int annee, mois, jour;
    do
    {
        try
        {
            Console.WriteLine("\nDate de Naissance : ");
            Console.Write("Année : ");
            annee = int.Parse(Console.ReadLine());

            if(annee > DateTime.Today.Year)
                throw new InvalidDateException("Année incorrect ! ");

            Console.Write("Mois : ");
            mois = int.Parse(Console.ReadLine());

            if (mois < 0 || mois > 11)
                throw new InvalidDateException("Mois incorrect !");

            Console.Write("Jour : ");
            jour = int.Parse(Console.ReadLine());

            if (jour < 0 || jour > 31)
                throw new InvalidDateException("Jour incorrect !");

            DateTime date = new DateTime(annee, mois, jour);

            if (date > DateTime.Today)
                throw new InvalidDateException("La date ne peut pas être postérieur à aujourd'hui !");

            return date;
        }
        catch (FormatException e)
        {
            Console.WriteLine("Erreur lors de la saisie : pas de caractere !\n");
            continue;
        }
        catch (InvalidDateException e)
        {
            Console.WriteLine(e.Message);
            continue;
        }


    } while (true);

}

Etudiant SaisieEtudiant(Etudiant etudiantAModifier = null)
{
    bool updateMode = etudiantAModifier != null;

    string nomUpdate = updateMode ? $"({etudiantAModifier.Nom})": "";
    string prenomUpdate = updateMode ? $"({etudiantAModifier.Prenom})": "";
    string dateUpdate = updateMode ? $"({etudiantAModifier.DateDeNaissance})": "";
    string emailUpdate = updateMode ? $"({etudiantAModifier.Email})": "";

    Console.WriteLine(updateMode ? 
        "=== MODIFICATION ETUDIANT ===\n" 
        : 
        "=== AJOUT ETUDIANT ===\n"); 

    Console.Write($"Veuillez saisir un nom {nomUpdate} : ");
    string nom = Console.ReadLine();

    Console.Write($"\nVeuillez saisir un prenom {prenomUpdate}: ");
    string prenom = Console.ReadLine();

    DateTime dob = SaisieDateDeNaissance();

    Console.Write($"\nVeuillez saisir un email {emailUpdate}: ");
    string email = Console.ReadLine();

    if (nom.Trim() == "" && updateMode)
        nom = etudiantAModifier.Nom;

    if (prenom.Trim() == "" && updateMode)
        prenom = etudiantAModifier.Prenom;

    if (email.Trim() == "" && updateMode)
        email = etudiantAModifier.Email;

    return new Etudiant(updateMode ? etudiantAModifier.Id : null, nom, prenom, dob, email); 
}

Etudiant RecupererUnEtudiantParId()
{
    AfficherEtudiants();

    Console.WriteLine();
    Console.Write("Veuillez saisir un ID : ");
    int.TryParse(Console.ReadLine(), out int id);

    Etudiant etudiant = EtudiantRepository.RecupereUnEtudiantParSonId(id);

    if (etudiant == null)
        throw new ArgumentException("Id invalide !");

    return etudiant; 
}

void AfficherMenu()
{
    Console.WriteLine("""
               _             _ _             _       
           ___| |_ _   _  __| (_) __ _ _ __ | |_ ___ 
          / _ \ __| | | |/ _` | |/ _` | '_ \| __/ __|
         |  __/ |_| |_| | (_| | | (_| | | | | |_\__ \
          \___|\__|\__,_|\__,_|_|\__,_|_| |_|\__|___/

        1. Voir tous les étudiants
        2. Ajouter un étudiant
        3. Modifier un étudiant
        4. Supprimer un étudiant
        5. Chercher un étudiant par nom ou prénom
        0. Quitter

        """);
}

void AfficherEtudiants(List<Etudiant> etudiants = null)
{
    if(etudiants == null)
        etudiants = EtudiantRepository.RecupererToutLesEtudiants();

    Console.WriteLine("=== LISTE DES ETUDIANTS ===");
    if (etudiants == null || etudiants.Count == 0)
    {
        Console.WriteLine("Aucun étudiant"); 
        return;
    }

    foreach (Etudiant e in etudiants)
    {
        Console.WriteLine(e);
    }
}

void RechercheEtudiants()
{
    Console.Write("Veuillez saisir le nom ou prénom recherché : ");
    string saisie = Console.ReadLine();

    List<Etudiant> etudiantTrouver = EtudiantRepository.RecupereToutLesEtudiantsParNomOuPrenom(saisie);
    AfficherEtudiants(etudiantTrouver);
}

void AjouterEtudiant()
{
    Etudiant etudiantAInserer = SaisieEtudiant();
    EtudiantRepository.AjouterUnEtudiant(etudiantAInserer);
}

void ModifierEtudiant()
{
    Etudiant etudiantAModifier;
    try
    {
        etudiantAModifier = RecupererUnEtudiantParId();
        etudiantAModifier = SaisieEtudiant(etudiantAModifier);
        EtudiantRepository.ModifierUnEtudiant(etudiantAModifier);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

void SupprimerEtudiant()
{
    try
    {
        Etudiant etudiantASupprimer = RecupererUnEtudiantParId();
        EtudiantRepository.SupprimerUnEtudiant(etudiantASupprimer.Id ?? -1);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}


int choix = -1;
EtudiantRepository.CreerTableEtudiant();

do
{
    AfficherMenu();
    Console.Write("Votre choix : ");

    while (!int.TryParse(Console.ReadLine(), out choix))
    {
        Console.WriteLine("\nVeuillez saisir un nombre..");
        Console.Write("Votre choix : ");
    }

    Console.WriteLine();
    switch (choix)
    {
        case 0:
            Console.WriteLine("\nAu revoir !");
            break;
        case 1:
            AfficherEtudiants();
            break;
        case 2:
            AjouterEtudiant();
            break;
        case 3:
            ModifierEtudiant();
            break;
        case 4:
            SupprimerEtudiant();
            break;
        case 5:
            RechercheEtudiants();
            break;
        default:
            Console.WriteLine("Choix invalide !");
            break;
    }

    Console.WriteLine("\n--- Press Enter to continue ---");
    Console.ReadLine();
    Console.Clear();

}while(choix != 0);