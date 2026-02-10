using DemoEntityFramework.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Model
{
    [Table("commande")]
    internal class Commande
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("description")]
        [StringLength(255)]
        public string Description { get; set; } = null!;

        [Required]
        [Column("total")]
        public decimal Total { get; set; }

        [Required]
        [Column("date_commande")]
        public DateTime DateCommande { get; set; } = DateTime.Now;

        // Clé étrangère 
        [Required]
        [Column("personne_id")]
        public int PersonneId { get; set; }

        // Navigation vers Personne
        // [ForeignKey("PersonneId")] => Pas obligatoire si leur noms correspondent 
        public Personne? Personne { get; set; }

        public Commande() { }

        public Commande(string description, decimal total, DateTime dateCommande, int personneId)
        {
            Description = description;
            Total = total;
            DateCommande = dateCommande;
            PersonneId = personneId;
        }

        public override string ToString()
        {
            return $"{Id} - {Description} ({DateCommande})";
        }
    }
}
