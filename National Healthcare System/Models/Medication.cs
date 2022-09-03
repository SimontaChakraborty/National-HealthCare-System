using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace National_Healthcare_System.Models
{
    public class Medication
    {
        [Key]
        public Guid Medication_Id { get; set; }

        public Guid Prescription_Id { get; set; }

        [Required]
        public DateTime DateOfMedication { get; set; } = DateTime.Now;

        [Required]
        public string Medications { get; set; }

        public Prescription Prescription { get; set; }
    }
}
