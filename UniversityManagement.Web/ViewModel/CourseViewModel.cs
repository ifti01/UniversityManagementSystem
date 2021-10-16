using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagement.Entities;

namespace UniversityManagement.Web.ViewModel
{
    public class CourseViewModelCreate
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<Department> departments { get; set; }
        public string SemesterString { get; set; }
        public Semester Semester { get; set; }
        public List<Semester> Semesters { get; set; }

    }
    public class CourseListingViewModel
    {
        public List<Course> Courses { get; set; }
    }

}