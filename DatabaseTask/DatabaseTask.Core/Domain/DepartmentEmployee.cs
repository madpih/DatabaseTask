using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class DepartmentEmployee
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime WorkingFromDate { get; set; }
        public DateTime WorkingUntilDate { get; set; }

        public Employee Employee { get; set; }
        public Department Department { get; set; }
    }
}
