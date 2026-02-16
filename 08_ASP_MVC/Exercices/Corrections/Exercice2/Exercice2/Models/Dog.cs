namespace Exercice2.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }

        public Dog() { }
        public Dog(int id, string name, string breed, int age)
        {
            Id = id;
            Name = name;
            Breed = breed;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} {Breed} ({Age} ans)";
        }
    }
}
