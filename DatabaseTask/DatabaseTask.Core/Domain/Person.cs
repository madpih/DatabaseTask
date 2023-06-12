using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Person
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PersonalIDCode { get; set; }
        public int ContactPhoneNumber { get; set; }
        public string? ContactAddress { get; set; }

        public ICollection<Employee> Employee { get; set; }
        public ICollection<Employee_child> Employee_child { get; set; }
    }
}
