using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoEntityFramework.Model
{
    [Table("personne")]
    internal class Personne
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("first_name")]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [Column("last_name")]
        [StringLength(255)]
        public string LastName { get; set; }

        [Required]
        [Column("age")]
        [Range(0, 130)]
        public int Age { get; set; }

        [Phone]
        [Column("phone")]
        [StringLength(10)]
        public string Phone { get; set; }

        [EmailAddress]
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }

        // Pour qu'EF fonctionne sans soucis, il doit y avoir un contructeur vide par défaut.
        public Personne() { }

        // Comme EF s'occupe de tout pour la bdd, pas besoin d'ID dans notre constructeur de base.
        public Personne(string firstName, string lastName, int age, string phone, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Phone = phone;
            Email = email;
        }

        public override string ToString() 
        {
            return $"Id : {Id}, Name : {FirstName} {LastName}, Age : {Age}, Contact : {Phone} {Email}."; 
        }

    }
}
