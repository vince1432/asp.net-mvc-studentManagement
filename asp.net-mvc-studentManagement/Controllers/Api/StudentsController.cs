using asp.net_mvc_studentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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
            var students = _context.StudentModels.ToList();

            return Ok(students);
        }

    }
}
