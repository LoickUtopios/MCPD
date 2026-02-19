using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice6.Models;

namespace Exercice6.Interfaces
{
    public interface IStudentService
    {
        public List<Student> GetAllStudents();
        public Student AddStudent (Student student);
    }
}
