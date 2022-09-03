using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace National_Healthcare_System.Models
{
    public class Users : IdentityUser
    {
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public string Fathers_Name { get; set; }
        public string Father_NID_Number { get; set; }
        public string Mothers_Name { get; set; }
        public string Mother_NID_Number { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Permanent_Address { get; set; }
        public string Current_Address { get; set; }
        public string Occupation { get; set; }
        public string Maritual_status { get; set; }
        public string Identity_Number { get; set; }
        public string City { get; set; }
        public string Blood_Group { get; set; }
        [Required(ErrorMessage = "Please choose profile image")]
        public string ProfilePicture { get; set; }
    }
}
