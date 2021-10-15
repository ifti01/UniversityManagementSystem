using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Data;
using UniversityManagement.Entities;

namespace UniversityManagement.Service
{
    public class DepartmentService
    {
        #region Singleton
        public static DepartmentService Instance
        {
            get
            {
                if (instance == null) instance = new DepartmentService();

                return instance;
            }
        }
        private static DepartmentService instance { get; set; }

        private DepartmentService()
        {
        }

        #endregion
        UniversityContext context = new UniversityContext();
        public List<Department> AllDepartmentsInfo()
        {
            return context.Departments.ToList();
        }
        public void SaveDept(Department department)
        {


            context.Departments.Add(department);
            context.SaveChanges();
        }
    }
}
