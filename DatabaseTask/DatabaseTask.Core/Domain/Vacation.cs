using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Vacation
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Boolean PaymentWithSalary { get; set; }
        public string? Comment { get; set; }



        public Employee Employee { get; set; }
        public VacationType VacationType { get; set; }
        //public Payroll_items Payroll_items { get; set; }
        public List<Payroll_items> Payroll_Items { get; set; } = new List<Payroll_items>();
    }

}
