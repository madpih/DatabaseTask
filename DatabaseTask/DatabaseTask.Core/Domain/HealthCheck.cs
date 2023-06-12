using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class HealthCheck
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime? CheckDate { get; set; }
        public string MedicalInstitution { get; set; }
        public string Findings { get; set; }
        public string? Comment { get; set; }


        public Employee Employee { get; set; }
    }
}
