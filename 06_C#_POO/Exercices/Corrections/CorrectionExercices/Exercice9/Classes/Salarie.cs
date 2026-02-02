
namespace Exercice9.Classes
{
    internal class Salarie 
    {
        public string Nom {  get; set; }
        public string Service { get; set; }
        public double Salaire { get; set; }

        public static int NbEmploye { get; set; }
        public static double TotalSalaire { get; set; }


        public Salarie() { NbEmploye++; }
        public Salarie(string nom, string service, double salaire): this() 
        {
            Nom = nom;
            Service = service;
            Salaire = salaire;
            TotalSalaire += salaire;  
        }

        public virtual void AfficherSalaire()
        {
            Console.WriteLine($"Le salaire de {Nom} est de {Salaire} euros.");
        }

        public static void AfficherTotalSalaire()
        {
            Console.WriteLine($"Le montant total des salaires des {NbEmploye} employés est de {TotalSalaire} euros.");
        }

        public static void LicenciementTotal()
        {
            NbEmploye = 0;
            TotalSalaire = 0;
            Console.WriteLine($"Il y a {NbEmploye} employe(es) dans l'entreprise (après reset)"); 
        }
    }
}
