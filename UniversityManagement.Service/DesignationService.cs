using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Data;
using UniversityManagement.Entities;

namespace UniversityManagement.Service
{
    public class DesignationService
    {
        #region Singleton
        public static DesignationService Instance
        {
            get
            {
                if (instance == null) instance = new DesignationService();

                return instance;
            }
        }
        private static DesignationService instance { get; set; }

        private DesignationService()
        {
        }

        #endregion

        UniversityContext context = new UniversityContext();

        public List<Designation> AllDesignationInfo()
        {
            return context.Designations.ToList();
        }

        public Designation GetDesignationbyId(int Id)
        {
            return context.Designations.Find(Id);
        }
    }
}
