using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
   public class Rent_item
    {
        [Key]
        public Guid Id { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public DateTime InRentFromDate { get; set; }
        public DateTime InRentUntilDate { get; set; }

        public Branch Branch { get; set; }
    }
}
