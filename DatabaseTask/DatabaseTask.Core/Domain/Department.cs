using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Department
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Boolean IsActive { get; set; }

        public Branch Branch { get; set; }
        public ICollection<DepartmentEmployee> DepartmentEmployees { get; set; }
        public ICollection<DepartmentManager> DepartmentManagers { get; set; }
    }
}
