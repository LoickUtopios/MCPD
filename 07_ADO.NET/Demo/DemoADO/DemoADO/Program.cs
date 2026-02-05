using DemoADO.Classes.Model;
using DemoADO.Classes.Repository;
using MySql.Data.MySqlClient;


PersonneRepository pRepo = new PersonneRepository();

pRepo.CreateTablePersonne();
//pRepo.AjouterUnePersonne(new Personne(null, "Titi", "Tutu", 40, "test3@test.com"));
//pRepo.ModifierUnePersonne(new Personne(1, "Toto","Tata", 50, "toto@tata.com"));
//pRepo.SupprimerUnePersonne(2);

List<Personne> personnes = pRepo.AfficherToutesLesPersonnes();
foreach(Personne personne in personnes)
{
    Console.WriteLine(personne);
}

Console.WriteLine(pRepo.AfficherUnePersonneParSonId(1));
