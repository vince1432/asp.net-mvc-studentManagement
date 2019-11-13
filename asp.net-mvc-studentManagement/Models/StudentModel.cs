using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp.net_mvc_studentManagement.Models
{
    public class StudentModel
    {

        public int Id { get; set; }
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }


    }
}