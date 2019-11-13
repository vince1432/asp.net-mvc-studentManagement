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
            var studentsInDb = _context.StudentModels.Include(c => c.Course).ToList();
            var students = new StudentViewModel
            {
                Students = studentsInDb
            };
            return View(students);
        }

        public ActionResult Student(int id)
        {
            var studentsInDb = _context.StudentModels.Include(c => c.Course).SingleOrDefault(c => c.Id == id);

            var students = new StudentModel
            {
                Id = studentsInDb.Id,
                FirstName = studentsInDb.FirstName,
                LastName = studentsInDb.LastName,
                BirthDate = studentsInDb.BirthDate,
                CourseId =studentsInDb.CourseId
                
            };

            return View(students);
        }
    }
}