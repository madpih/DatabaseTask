using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Employee_access
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime ValidFromDate { get; set; }
        public DateTime ValidUntilDate { get; set; }


        public Employee Employee { get; set; }
        public AccessType AccessType { get; set; }
    }
}
