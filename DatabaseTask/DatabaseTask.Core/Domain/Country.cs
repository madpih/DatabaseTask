using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Country
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        //public Firm Firm { get; set; }
        ///public List<Firm> Firms { get; set; } = new List<Firm>();
        public ICollection<Firm>? Firms { get; set; }
        //public ICollection<Branch> Branches { get; set; }
    }
}
