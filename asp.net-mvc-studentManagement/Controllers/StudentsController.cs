using asp.net_mvc_studentManagement.Models;
using asp.net_mvc_studentManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace asp.net_mvc_studentManagement.Controllers
{
    public class StudentsController : Controller
    {
        private ApplicationDbContext _context;

        public StudentsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Students
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Student(int id)
        {
            var studentsInDb = _context.StudentModels.Include(c => c.Course).SingleOrDefault(c => c.Id == id);

            return View(studentsInDb);
        }

        public ViewResult CreateStudent()
        {
            var coursesInDb = _context.Courses.ToList();

            var courses = new StudentViewModel
            {
                Course = coursesInDb
            };
            return View(courses);
        }

        [HttpPost]
        public ActionResult Create(StudentModel student)
        {
            student.BirthDate = DateTime.Now;
            _context.StudentModels.Add(student);
            _context.SaveChanges();

            return RedirectToAction("Index", "Students");
        }

        public ViewResult Views()
        {
            var coursesInDb = _context.Courses.ToList();

            var courses = new StudentViewModel
            {
                Course = coursesInDb
            };
            return View(courses);
        }


    }
}