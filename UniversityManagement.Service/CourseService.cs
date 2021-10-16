using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Data;
using UniversityManagement.Entities;

namespace UniversityManagement.Service
{ 
    public class CourseService
    {

        #region Singleton
        public static CourseService Instance
        {
            get
            {
                if (instance == null) instance = new CourseService();

                return instance;
            }
        }
        private static CourseService instance { get; set; }

        private CourseService()
        {
        }

        #endregion

        UniversityContext context = new UniversityContext();
        
        public List<Course> AllCoursesInfo()
        {
            return context.Courses.ToList();
        }
        public void SaveCourse(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
        }
    }
}
