using CorrectionExercices1.Class.Exceptions;
using CorrectionExercices1.Class.Model;
using CorrectionExercices1.Class.Repository;
using System.Collections.Generic;


// Cette fonction permet la saisie et la vérification de la date de naissance.
DateTime SaisieDateDeNaissance()
{
    int annee, mois, jour;

    // Tant que la date est invalide, je boucle
    do
    {
        try
        {

            // Saisie de l'année de naissance
            Console.WriteLine("\nDate de Naissance : ");
            Console.Write("Année : ");
            // Utilisation de Parse pour la conversion (catch plus bas si erreur de saisie)
            annee = int.Parse(Console.ReadLine());

            // Si l'année est dans le futur ou il y a plus de 130 ans alors erreur.
            if(annee > DateTime.Today.Year || annee < DateTime.Today.Year - 130)
                throw new InvalidDateException("Année incorrect ! ");

            Console.Write("Mois : ");
            mois = int.Parse(Console.ReadLine());

            // Le mois doit etre compris entre 1 et 12
            if (mois < 1 || mois > 12)
                throw new InvalidDateException("Mois incorrect !");

            Console.Write("Jour : ");
            jour = int.Parse(Console.ReadLine());

            // Le jour doit etre compris entre 1 et 31
            if (jour < 1 || jour > 31)
                throw new InvalidDateException("Jour incorrect !");

            DateTime date = new DateTime(annee, mois, jour);

            // Meme si chaque élément est correct, on vérifier si la date n'est pas dans le futur.
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

// Cette fonctioner permet la saisie d'un étudiant (ajout ou modification)
// S'il reçoit un Etudiant en parametre, la fonction passe en edition sinon en ajout.
Etudiant SaisieEtudiant(Etudiant etudiantAModifier = null)
{
    // On vérifie si on est en édition (si un étudiant est donnée). 
    bool updateMode = etudiantAModifier != null;

    // Si je suis en édition, je peut afficher les données de base sinon rien.
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

    // Si le nom, prenom ou email est vide, c'est que l'on garde les valeur de base.
    // Pas de modification
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
    // Tout d'abord, j'affiche les étudiants et leur ID. 
    AfficherEtudiants();

    Console.WriteLine();
    Console.Write("Veuillez saisir un ID : ");
    // Je récupère la saisie de l'utilisateur et si je ne peut pas convertir id = 0
    // (comme auto_increment commence à 0, id invalide de base)
    int.TryParse(Console.ReadLine(), out int id);

    // Je récupère l'étudiant via son ID mais je recupère null si introuvable.
    Etudiant etudiant = EtudiantRepository.RecupereUnEtudiantParSonId(id);

    // Si c'est null, alors ID invalide ou inexistant.
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

// Cette fonction affiche de base tout les étudiants OU la liste d'étudiant donné en paramètres.
void AfficherEtudiants(List<Etudiant> etudiants = null)
{
    // Si aucune liste donnée alors je recupére tout les étudiant
    if(etudiants == null)
        etudiants = EtudiantRepository.RecupererToutLesEtudiants();

    Console.WriteLine("=== LISTE DES ETUDIANTS ===");

    // Si la liste est vide alors j'affiche 'aucun étudiant'
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

// Cette fonction permet de rechercher un étudiant via son nom ou prénom
void RechercheEtudiants()
{
    Console.Write("Veuillez saisir le nom ou prénom recherché : ");
    string saisie = Console.ReadLine();

    // Je recupère la liste de tout les étudiants correspondant
    List<Etudiant> etudiantTrouver = EtudiantRepository.RecupereToutLesEtudiantsParNomOuPrenom(saisie);
    
    // Je fournis cette liste à AfficherEtudiant qui va m'afficher les étudiants trouvé.
    AfficherEtudiants(etudiantTrouver);
}

void AjouterEtudiant()
{
    // Pour ajouter un étudiant, je saisie ses informations. 
    Etudiant etudiantAInserer = SaisieEtudiant();
    // Puis je l'ajoute en BDD
    EtudiantRepository.AjouterUnEtudiant(etudiantAInserer);
}

void ModifierEtudiant()
{
    Etudiant etudiantAModifier;
    try
    {
        // Pour modifier un étudiant, je demande de le récupère via son ID.
        etudiantAModifier = RecupererUnEtudiantParId();
        // Je saisie ses nouvelles informations si nécessaire.
        etudiantAModifier = SaisieEtudiant(etudiantAModifier);
        // Je met à jour les données en BDD
        EtudiantRepository.ModifierUnEtudiant(etudiantAModifier);
    }
    catch (ArgumentException ex)
    {
        // Si l'id est invalide, j'affice l'erreur
        Console.WriteLine(ex.Message);
    }
}

void SupprimerEtudiant()
{
    try
    {
        // Pour supprimer un étudiant, je vérifie s'il existe via son ID
        Etudiant etudiantASupprimer = RecupererUnEtudiantParId();
        // Si je trouve quelqu'un, je le supprime via son ID.
        EtudiantRepository.SupprimerUnEtudiant(etudiantASupprimer.Id ?? -1);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

/*
 * 
 * PROGRAMME PRINCIPAL 
 * 
*/

int choix = -1;
EtudiantRepository.CreerTableEtudiant();

// Tant que l'utilisateur ne choisit pas de quitter, je boucle mon IHM.
do
{
    AfficherMenu();
    Console.Write("Votre choix : ");

    // Tant que le choix de l'utilisateur n'est pas un nombre, je redemande.
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