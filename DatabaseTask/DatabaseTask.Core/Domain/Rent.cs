using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Rent
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime RentStartDate { get; set; }
        public DateTime RentEndDate { get; set; }


        public Employee Employee { get; set; }
        public Rent_item Rent_item { get; set; }
    }
}
