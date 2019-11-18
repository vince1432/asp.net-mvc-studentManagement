using asp.net_mvc_studentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using asp.net_mvc_studentManagement.ViewModel;

namespace asp.net_mvc_studentManagement.Controllers.Api
{
    public class StudentsController : ApiController
    {

        private ApplicationDbContext _context;

        public StudentsController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetStudents()
        {
            var students = _context.StudentModels.Include(c => c.Course).ToList();

            return Ok(students);
        }

        public IHttpActionResult GetStudents(int id)
        {
            var students = _context.StudentModels.Include(c => c.Course).SingleOrDefault();

            return Ok(students);
        }


        [HttpPost]
        public IHttpActionResult CreateStudent(StudentModel student)
        {
            _context.StudentModels.Add(student);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri +"/" + student.Id),student);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, StudentViewModel student)
        {
            var studentInDb = _context.StudentModels.SingleOrDefault(m => m.Id == id);

            studentInDb.FirstName = student.FirstName;
            studentInDb.LastName = student.LastName;
            studentInDb.BirthDate = student.BirthDate;
            studentInDb.CourseId = student.CourseId;
         
            _context.SaveChanges();

            return Ok(student);

        }


        [HttpDelete]
        public IHttpActionResult DeleteStudent(int id)
        {

            var studentInDb = _context.StudentModels.SingleOrDefault(m => m.Id ==  id);
            _context.StudentModels.Remove(studentInDb);
            _context.SaveChanges();
            return Ok();
        }

    }
}
