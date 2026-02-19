using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [NotNull]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [NotNull]
        [StringLength(255)]
        public string LastName { get; set; }
        [Required]
        [NotNull]
        [Range(0,120)]
        public int Age { get; set; }
        [Required]
        [NotNull]
        [EmailAddress]
        public string Email { get; set; }


        public Student() { }
        public Student(string firstname, string lastname,int age,string email)
        {
            FirstName=firstname;
            LastName=lastname;
            Age=age;
            Email=email;
        }

        public override string ToString()
        {
            return $"{Id} - {FirstName} {LastName} ({Age} ans) : {Email}";
        }
    }
}
