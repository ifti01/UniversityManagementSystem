using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement.Entities
{
    public class Course:BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int  Credit { get; set; }
        public string Description { get; set; }
        public virtual Department Department { get; set; }
        public int DepartmentId { get; set; }


        [Column("Semester")]
        public string SemesterString
        {
            get { return Semester.ToString(); }
            set
            {
                if (Enum.TryParse(value, out Semester newValue))
                { Semester = newValue; }
            }
        }

        [NotMapped]
        public Semester Semester { get; set; }

    }
}
