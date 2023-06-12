using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class AccessType
    {
        [Key]
        public Guid Id { get; set; }
        public string TypeName { get; set; }
        public DateTime ValidFromDate { get; set; }
        public DateTime ValidUntilDate { get; set; }
        public string? Comment { get; set; }

        public ICollection<Employee_access> Employee_accesses { get; set; }
    }
}
