using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice6.Models;
using Exercice6.Service;

namespace Exercice6.Interfaces
{
    public interface IStudentRepository
    {
        public List<Student> GetAllStudents();
        public Student AddStudent(Student student);
    }
}
