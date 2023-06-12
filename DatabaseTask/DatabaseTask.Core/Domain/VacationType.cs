using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class VacationType
    {
        [Key]
        public Guid Id { get; set; }
        public string TypeName { get; set; }
        public Boolean TypeInUse { get; set; }
        public int VacationDays { get; set; }
        public string? Comment { get; set; }

        public ICollection<Vacation> Vacations { get; set; }
    }
}
