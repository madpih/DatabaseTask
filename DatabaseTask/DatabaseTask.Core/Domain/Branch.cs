using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Branch
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Reg_Code { get; set; }
        public string Address { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }


        public Firm? Firm { get; set; }
        public Country? Country { get; set; }
        public ICollection<Tip> Tips { get; set; }
        public ICollection<Rent_item> Rent_items { get; set; }
        public ICollection<Department> Departments { get; set; }

    }
}
