using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Profession
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime ValidSince { get; set; }
        public DateTime ValidUntil { get; set; }

        public ICollection<Employee_Profession> EmployeeProfessions { get; set; }
    }
}
