using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Employee_child
    {
        [Key]
        public Guid Id { get; set; }
        
        public Employee Employee { get; set; }
       // public Person Person { get; set; }
    }
}
