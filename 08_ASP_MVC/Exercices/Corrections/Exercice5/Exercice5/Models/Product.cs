using System.ComponentModel.DataAnnotations;

namespace Exercice5.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Le nom est obligatoire")]
        [StringLength(255, ErrorMessage ="Le nom du produit doit être au maximum de 255 caractère")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Le prix est obligatoire")]
        [Range(1,double.MaxValue, ErrorMessage ="Le prix doit être supérieur à 0")]
        public double Price { get; set; }
        [Required(ErrorMessage = "La categorie est obligatoire")]
        [StringLength(255, ErrorMessage = "Le nom de la categorie doit être au maximum de 255 caractère")]
        public string Category { get; set; }

        public Product() { }
        public Product(int id, string name, double price, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} {Price} {Category}";
        }
    }
}
