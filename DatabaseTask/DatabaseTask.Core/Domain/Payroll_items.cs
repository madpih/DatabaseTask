using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Payroll_items
    {
        [Key]
        public Guid Id { get; set; }
        public int PayrollItemAmount { get; set; }
        public string? Comment { get; set; }


        public PayoutType? PayoutType { get; set; }
        public Vacation? Vacation { get; set; }
        public SickLeave? SickLeave { get; set; }
        public Salary? Salary { get; set; }
        public WorkingSchedule? WorkingSchedule { get; set; }
    }
}
