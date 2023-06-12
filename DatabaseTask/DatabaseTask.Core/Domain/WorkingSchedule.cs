using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class WorkingSchedule
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public int HoursWorked { get; set; }
        public int OnCallHours { get; set; }
        public int ExtraHours { get; set; }
        public string? Comment { get; set; }


        public EmploymentContract EmploymentContract { get; set; }
    }
}
