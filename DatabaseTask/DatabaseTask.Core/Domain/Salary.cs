using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{ 
    public class Salary
        {
            [Key]
            public Guid Id { get; set; }
            public DateTime AccountingMonth { get; set; }
            public int GrossAmount { get; set; }
            public int IncomeTaxExemptMinimum { get; set; }
            [Column(TypeName = "decimal(18,2)")]
            public decimal WithholdingTaxAmount { get; set; }
           [Column(TypeName = "decimal(18,2)")]
            public decimal PayoutNetAmount { get; set; }
            public DateTime PayoutDate { get; set; }
            public string AccountNumber { get; set; }
            public string? Comment { get; set; }

            public Employee Employee { get; set; }
            public ICollection<Payroll_items> Payroll_items { get; set; }
        }

}
