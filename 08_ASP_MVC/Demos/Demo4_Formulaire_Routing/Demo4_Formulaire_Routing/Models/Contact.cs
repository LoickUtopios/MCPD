using System.ComponentModel.DataAnnotations;

namespace Demo4_Formulaire_Routing.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [Range(0, 120, ErrorMessage ="Entre 0 et 120 SVP")]
        public int Age {  get; set; }
        [Required]
        [StringLength(200)]
        public string Description { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }

        public Contact() { }
        public Contact(int id, string name, string description, string phone, int age)
        {
            Id = id;
            Name = name;
            Description = description;
            Phone = phone;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Id} {Name} ({Age}) {Description} {Phone}";
        }
    }

}
