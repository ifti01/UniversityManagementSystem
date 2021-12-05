﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement.Entities
{
    public class Teacher:BaseEntity
    { 
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public int Credit { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual Department Department { get; set; }
        public int DepartmentId { get; set; }
        public int DesignationId { get; set; }

    }
}
