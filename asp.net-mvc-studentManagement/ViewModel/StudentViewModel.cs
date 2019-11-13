using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using asp.net_mvc_studentManagement.Models;
namespace asp.net_mvc_studentManagement.ViewModel
{
    public class StudentViewModel
    {
        public List<StudentModel> Students { get; set; }
        public Courses Course { get; set; }
    }
}