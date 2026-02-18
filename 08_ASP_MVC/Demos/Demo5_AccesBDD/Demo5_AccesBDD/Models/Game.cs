namespace Demo5_AccesBDD.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }

        public Game() { }
        public Game(string name, string description, double price, double amount) 
        {
            Name = name;
            Description = description;
            Price = price;
            Amount = amount;
        }

    }
}
