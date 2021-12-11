using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Data;
using UniversityManagement.Entities;
using System.Data.Entity;

namespace UniversityManagement.Service
{
    public class TeacherService
    {
        #region Singleton
        public static TeacherService Instance
        {
            get
            {
                if (instance == null) instance = new TeacherService();

                return instance;
            }
        }
        private static TeacherService instance { get; set; }

        private TeacherService()
        {
        }

        #endregion

        UniversityContext context = new UniversityContext();

        public List<Teacher> AllTeachersInfo()
        {
            //Name is fetching from Designation and Department Tables 
            return context.Teachers.Include(x => x.Department).Include(x => x.Designation).ToList();
        }
        public void SaveTeacher(Teacher teacher)
        {
            context.Teachers.Add(teacher);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}
