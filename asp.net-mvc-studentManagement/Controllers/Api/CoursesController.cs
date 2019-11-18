using asp.net_mvc_studentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace asp.net_mvc_studentManagement.Controllers.Api
{
    public class CoursesController : ApiController
    {

        private ApplicationDbContext _context;

        public CoursesController()
        {
            _context = new ApplicationDbContext();
        }


        public IHttpActionResult GetCourses()
        {
           var courses = _context.Courses.ToList();

            return Ok(courses);
        }

        public IHttpActionResult GetCourses(int id)
        {

            var course = _context.Courses.SingleOrDefault(m => m.Id == id);

            return Ok(course);
        }

        [HttpPost]
        public IHttpActionResult AddCourse(Courses course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + course.Id),course);
        }

        [HttpPut]
        public IHttpActionResult UpdateCourse(Courses course)
        {
            var courseInDb = _context.Courses.SingleOrDefault(m => m.Id == course.Id);

            courseInDb.Name = course.Name;
            courseInDb.Description = course.Description;

            return Ok(courseInDb);
        }

        [HttpDelete]
        public IHttpActionResult DeleteCourse(int id)
        {
            var courseInDb = _context.Courses.SingleOrDefault(m => m.Id == id);

            _context.Courses.Remove(courseInDb);
            _context.SaveChanges();

            return Ok();
        }
        
    }
}
