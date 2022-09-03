using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace National_Healthcare_System.Models
{
    public class Prescription
    {

        [Key]
        [Display(Name = "Prescription ID")]
        public Guid Prescription_Id { get; set; }

        public Guid Consultation_Id { get; set; }

        [Required]
        [Display(Name = "Comments")]
        public string Comments { get; set; }

        public Consultation Consultation { get; set; }
    }
}
