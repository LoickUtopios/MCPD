using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice6.DBManager;
using Exercice6.Interfaces;
using Exercice6.Models;

namespace Exercice6.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext _context;

        public StudentRepository(StudentDbContext context)
        {
            _context = context;
        }
        public Student AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }
        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }
    }
}
