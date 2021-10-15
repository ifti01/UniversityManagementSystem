using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement.Entities
{ 
    public class Department:BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
