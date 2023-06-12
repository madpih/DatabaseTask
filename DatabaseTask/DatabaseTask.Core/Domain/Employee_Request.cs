using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Employee_Request
    {
        [Key]
        public Guid Id { get; set; }
        public string Content { get; set; }
        public DateTime DateAdded { get; set; }
        public string? Comment { get; set; }


        public Employee Employee { get; set; }

    }
}
