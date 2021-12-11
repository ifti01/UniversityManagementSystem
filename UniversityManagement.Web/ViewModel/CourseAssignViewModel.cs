using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagement.Entities;

namespace UniversityManagement.Web.ViewModel
{
    public class CourseAssignViewModel
    {
        public Department Department { get; set; }
        public Teacher Teacher { get; set; }
        public int DepartmentId { get; set; }
        public int TeacherId { get; set; }
        public int TakenCredit { get; set; }
        public int RemainCredit { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }
        public List<Department> departments { get; set; }
        public List<Designation> designations { get; set; }
        public List<Course> courses { get; set; }
        public List<Teacher> teachers { get; set; }

    }

    public class CourseAssignListingViewModel
    {
        public List<CourseAssign> courseassigns { get; set; }

    }
}