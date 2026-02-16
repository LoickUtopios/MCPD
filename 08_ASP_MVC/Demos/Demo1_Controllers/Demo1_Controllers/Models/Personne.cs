namespace Demo1_Controllers.Models
{
    public class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }

        public Personne() { }
        public Personne(int id, string nom, string prenom, int age)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Id} {Nom} {Prenom} {Age}";
        }
    }
}
