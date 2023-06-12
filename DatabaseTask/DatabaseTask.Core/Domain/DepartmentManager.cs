using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class DepartmentManager
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime ManagerFromDate { get; set; }
        public DateTime ManagerUntilDate { get; set; }


        public Department Department { get; set; }
        public Employee Employee { get; set; }
    }
}
