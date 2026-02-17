namespace Demo3_Model.Models
{
    public class Personne
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }

        public Personne() { }
        public Personne(int id, string name, string description, int age)
        {
            Id = id;
            Name = name;
            Description = description;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} {Description} ({Age})";
        }
    }
}
