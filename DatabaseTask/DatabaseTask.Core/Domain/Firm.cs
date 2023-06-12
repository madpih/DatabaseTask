using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Firm
    {
        [Key]

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int RegCode { get; set; }
        public string Address { get; set; }
        public int ContactNumber { get; set; }
        public string? ContactEmail { get; set; }


        public Country? Country { get; set; }
        public ICollection<Branch>? Branches { get; set; }

    }
}
