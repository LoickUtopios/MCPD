using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice6.Interfaces;
using Exercice6.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercice6.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

         [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View("AddStudent", student);
            }
            _studentService.AddStudent(student);

            return RedirectToAction("GetAllStudents");
        }
        
        [HttpGet]
        public IActionResult AddStudent()
        {
            Student s = new Student();
            return View(s);
        }

        public IActionResult GetAllStudents()
        {
            return View(_studentService.GetAllStudents());
        }

    }

}
