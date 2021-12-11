using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Data;
using UniversityManagement.Entities;

namespace UniversityManagement.Service
{
    public class CourseAssignService
    {
        #region Singleton
        public static CourseAssignService Instance
        {
            get
            {
                if (instance == null) instance = new CourseAssignService();

                return instance;
            }
        }
        private static CourseAssignService instance { get; set; }

        private CourseAssignService()
        {
        }

        #endregion

        UniversityContext context = new UniversityContext();

        public List<CourseAssign> AllAssignCoursesInfo()
        {
            return context.CourseAssigns.ToList();
        }
        public void SaveCourse(CourseAssign courseassign)
        {
            context.CourseAssigns.Add(courseassign);
            context.SaveChanges();
        }
    }
}

