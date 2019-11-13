using asp.net_mvc_studentManagement.Models;
using asp.net_mvc_studentManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp.net_mvc_studentManagement.Controllers
{
    public class CoursesController : Controller
    {

        private ApplicationDbContext _context;

        public CoursesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Courses
        public ActionResult Index()
        {
            var coursesInDb =_context.Courses.ToList();

            var courses = new CoursesViewModel
            {
                Courses =coursesInDb
            };
            return View(courses);
        }
    }
}