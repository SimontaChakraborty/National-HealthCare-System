using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace National_Healthcare_System.Models
{
    public class Organization
    {
        [Key]
        public Guid Organization_Id { get; set; }

        [Required]
        [Display(Name = "Organization Name")]
        public string Organization_Name { get; set; }

        [Required]
        [Display(Name ="Registration Number")]
        public string Registration_No { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Organization_Address { get; set; }

        [Required]
        [Display(Name = "Contact Number")]
        [StringLength(11, ErrorMessage = "Invalid Phone number", MinimumLength = 11)]
        public string Organization_Contact { get; set; }

        [Required]
        [Display(Name = "Type of Organization")]
        public string Organization_Type { get; set; }

        public string Description { get; set; }
    }
}
