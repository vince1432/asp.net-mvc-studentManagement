using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using asp.net_mvc_studentManagement.Models;
namespace asp.net_mvc_studentManagement.ViewModel
{
    public class StudentViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Birth Date")]
        public DateTime? BirthDate { get; set; }

        [Required]
        [Display(Name = "Course")]
        public int CourseId { get; set; }
    
        public List<Courses> Course { get; set; }
    }
}