using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using National_Healthcare_System.Data;
using National_Healthcare_System.Models;

namespace National_Healthcare_System.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment webHostEnvironment;

        public IndexModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ApplicationDbContext db,
            IWebHostEnvironment hostEnvironment)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
            webHostEnvironment = hostEnvironment; 
        }

        public string ImageName { get; set; }
        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }
        

        public class InputModel
        {
            [Phone]
            [Display(Name = "Phone number")]
            [StringLength(11, ErrorMessage = "Invalid Phone number", MinimumLength = 11)]
            public string PhoneNumber { get; set; }
            [EmailAddress]
            public string Email { get; set; }

            [Display(Name = "First Name")]
            public string First_Name { get; set; }
            [Display(Name = "Middle Name")]
            public string Middle_Name { get; set; }
            [Display(Name = "Last Name")]
            public string Last_Name { get; set; }
            [Display(Name = "Fathers Name")]
            public string Fathers_Name { get; set; }
            [Display(Name = "Fathers NID Number")]
            public string Father_NID_Number { get; set; }
            [Display(Name = "Mothers Name")]
            public string Mothers_Name { get; set; }
            [Display(Name = "Mothers NID Number")]
            public string Mother_NID_Number { get; set; }
            [Display(Name = "Date Of Birth")]
            public DateTime DateOfBirth { get; set; }
            public string Gender { get; set; }
            [Display(Name = "Permanent Address")]
            public string Permanent_Address { get; set; }
            [Display(Name = "Current Address")]
            public string Current_Address { get; set; }
            public string Occupation { get; set; }
            [Display(Name = "Maritual status")]
            public string Maritual_status { get; set; }
            [Display(Name = "NID Number")]
            public string Identity_Number { get; set; }
            public string City { get; set; }
            [Display(Name = "Blood Group")]
            public string Blood_Group { get; set; }
            //[Required(ErrorMessage = "Please choose profile image")]
            [Display(Name = "Profile Picture")]
            public IFormFile ProfileImage { get; set; }
            public string ProfilePicture { get; set; }

        }

        private async Task LoadAsync(Users user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
        } 

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            var userFromDb = await _db.User.FirstOrDefaultAsync(u => u.Email == user.Email);
            ImageName = userFromDb.ProfilePicture.ToString();
            Username = userFromDb.UserName;
            
            Input = new InputModel
            {
                PhoneNumber = userFromDb.PhoneNumber,
                First_Name = userFromDb.First_Name,
                Middle_Name = userFromDb.Middle_Name,
                Last_Name = userFromDb.Last_Name,
                Fathers_Name = userFromDb.Fathers_Name,
                Father_NID_Number = userFromDb.Father_NID_Number,
                Mothers_Name = userFromDb.Mothers_Name,
                Mother_NID_Number = userFromDb.Mother_NID_Number,
                DateOfBirth = userFromDb.DateOfBirth,
                Gender = userFromDb.Gender,
                Permanent_Address = userFromDb.Permanent_Address,
                Current_Address = userFromDb.Current_Address,
                Occupation = userFromDb.Occupation,
                Maritual_status = userFromDb.Maritual_status,
                Identity_Number = userFromDb.Identity_Number,
                City = userFromDb.City,
                Blood_Group = userFromDb.Blood_Group,
                ProfilePicture = userFromDb.ProfilePicture,
            };   
            return Page();
        }
       
        private string UploadedFile(InputModel Input)
        {
            string uniqueFileName = null;

            if (Input.ProfileImage != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Input.ProfileImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Input.ProfileImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {           
                return Page();
            }
            string uniqueFileName = UploadedFile(Input);
            var userFromDb = await _db.User.FirstOrDefaultAsync(u => u.Email == user.Email);
            
            userFromDb.PhoneNumber = Input.PhoneNumber;
            userFromDb.First_Name = Input.First_Name;
            userFromDb.Middle_Name = Input.Middle_Name;
            userFromDb.Last_Name = Input.Last_Name;
            userFromDb.Fathers_Name = Input.Fathers_Name;
            userFromDb.Father_NID_Number = Input.Father_NID_Number;
            userFromDb.Mothers_Name = Input.Mothers_Name;
            userFromDb.Mother_NID_Number = Input.Mother_NID_Number;
            userFromDb.DateOfBirth = Input.DateOfBirth;
            userFromDb.Gender = Input.Gender;
            userFromDb.Permanent_Address = Input.Permanent_Address;
            userFromDb.Current_Address = Input.Current_Address;
            userFromDb.Occupation = Input.Occupation;
            userFromDb.Maritual_status = Input.Maritual_status;
            userFromDb.Identity_Number = Input.Identity_Number;
            userFromDb.City = Input.City;
            userFromDb.Blood_Group = Input.Blood_Group;
            userFromDb.ProfilePicture = uniqueFileName;
            
            await _db.SaveChangesAsync();

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
