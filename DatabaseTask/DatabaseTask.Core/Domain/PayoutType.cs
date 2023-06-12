using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class PayoutType
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Boolean TypeInUse { get; set; }

        public ICollection<Payroll_items> Payroll_items { get; set; }
    }
}
