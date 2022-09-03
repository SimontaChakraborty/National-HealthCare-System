using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace National_Healthcare_System.Models
{
    public class Doctor_Schedule
    {
        [Key]
        public int Schedule_Id { get; set; }

        public Guid Doctor_Id { get; set; }

        [Required]
        public string Day { get; set; }

        [Required]
        public DateTime Start_Time { get; set; }

        [Required]
        public DateTime End_Time { get; set; }

        [Required]
        [Display(Name = "Organization Name")]
        public string Organization_Name { get; set; }

        [Display(Name = "Chamber Address")]
        public string Chamber_Address { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
