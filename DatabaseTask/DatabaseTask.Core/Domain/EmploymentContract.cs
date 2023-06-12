using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class EmploymentContract
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateCreated { get; set; }
        public string ContractType { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Workload { get; set; }
        public int AmendmentNumber { get; set; }
        public int Salary { get; set; }



        public Employee Employee { get; set; }
        public ICollection<WorkingSchedule> WorkingSchedules { get; set; }
    }
}
