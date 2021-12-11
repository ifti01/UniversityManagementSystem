using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement.Entities
{
    public class CourseAssign:BaseEntity
    { 
        public virtual Department Department { get; set; } 
        public virtual Teacher Teacher { get; set; } 
        public int? DepartmentId { get; set; }
        public int TeacherId { get; set; }
        public int TakenCredit { get; set; }
        public int RemainCredit { get; set; }
        public virtual Course Course { get; set; }
        public int CourseId { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }
    }
}
