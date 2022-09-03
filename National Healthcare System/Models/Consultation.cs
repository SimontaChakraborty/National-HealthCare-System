using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace National_Healthcare_System.Models
{
    public class Consultation
    {

        [Key]
        [Display(Name = "Consultation ID")]
        public Guid Consultation_Id { get; set; }

        public Guid Doctor_Id { get; set; }

        [Required]
        [Display(Name = "Date and Time")]
        public DateTime Consultation_DateTime { get; set; } = DateTime.Now;

        [Display(Name = "NID/Birth Certificate No.")]
        [StringLength(13, ErrorMessage = "NID/Birth Certificate Number is Invalid Size", MinimumLength = 10)]
        public string Identity_Number { get; set; }

        [Required]
        [Display(Name = "Comment")]
        public string Comment { get; set; }
        
        public virtual Doctor Doctor { get; set; }

        public virtual Users Users { get; set; }
    }
}
