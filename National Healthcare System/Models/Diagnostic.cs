using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace National_Healthcare_System.Models
{
    [Authorize(Roles = "Admin, Doctor, Organization")]
    public class Diagnostic
    {
        [Key]
        [Display(Name = "Diagnostic Id")]
        public Guid Diagnostic_Id { get; set; }   

        public Guid Consultation_Id { get; set; }

        [Required]
        [Display(Name = "Date of Diagnose")]
        public DateTime DateOfDiagnose { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "Diagnostic Type")]
        public string Diagnostic_Type { get; set; }

        [Required]
        [Display(Name = "Result of Diagnostics")]
        public string Diagnostics { get; set; }

        public Guid Organization_Id { get; set; }

        [Required]
        public string Comments { get; set; }

        public string Image { get; set;  }

        public Consultation Consultation { get; set; }
        
        public Organization Organization { get; set; }
    }
}
