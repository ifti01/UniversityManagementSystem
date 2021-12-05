using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using UniversityManagement.Entities;

namespace UniversityManagement.Web.ViewModel
{
    public class TeacherViewModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public int Credit { get; set; } 
        public Designation Designation { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public int DesignationId { get; set; }
        public List<Department> departments { get; set; }
        public List<Designation> designations { get; set; }
    }


    public class TeacherListingViewModel
    { 
        public List<Teacher> Teachers { get; set; }
    }
}