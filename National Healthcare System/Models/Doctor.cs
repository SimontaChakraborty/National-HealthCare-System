using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace National_Healthcare_System.Models
{
    public class Doctor
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name = "Doctor Id")]
        public Guid Doctor_Id { get; set; }

        public string Identity_Number { get; set; }
        
        [Required]
        [Display(Name ="Registration Number")]
        [Range(1, 99999, ErrorMessage ="Invalid Registration Number Length")]
        public int Registration_Number { get; set; }

        [Required]
        [Display(Name = "Institution Name")]
        public string Institution_Name { get; set; }

        [Required]
        [Display(Name = "Doctor Type")]
        public string Doctor_Type { get; set; }

        [Required]
        public bool Specialist { get; set; }

        [Required]
        [Display(Name = "Consultation Address")]
        public string Consultation_Address { get; set; }

        [Required]
        [StringLength(11, ErrorMessage = "Invalid Phone number", MinimumLength = 11)]
        [Display(Name = "Consultation Contact")]
        public string Consultation_Contact { get; set; }

        public Guid Organization_Id { get; set; }

        [Required]
        public string Descriptions { get; set; }

        [Required]
        public bool Verified { get; set; }

        public ICollection<Consultation> Consultations { get; set; }

        public Organization Organization { get; set; }
        public Users Users { get; set; }

        public ICollection<Doctor_Schedule> Schedule { get; set; }
    }
}
