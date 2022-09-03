using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using National_Healthcare_System.Data;
using National_Healthcare_System.Models;
using National_Healthcare_System.Utility;

namespace National_Healthcare_System.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {       
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment webHostEnvironment;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext db,
            IWebHostEnvironment hostEnvironment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _db = db;
            _roleManager = roleManager;
            webHostEnvironment = hostEnvironment;

        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required]
            [Display(Name = "First Name")]
            public string First_Name { get; set; }

            [Display(Name = "Middle Name")]
            public string Middle_Name { get; set; }

            [Required]
            [Display(Name = "Last Name")]
            public string Last_Name { get; set; }

            [Required]
            [Display(Name = "Father's Name")]
            public string Fathers_Name { get; set; }
            
            [Display(Name = "Father's NID no.")]
            [StringLength(13, ErrorMessage = "NID Number is Invalid Size.", MinimumLength = 10)]
            public string Father_NID_Number { get; set; }

            [Required]
            [Display(Name = "Mother's Name")]
            public string Mothers_Name { get; set; }

            [Display(Name = "Mother's NID no.")]
            [StringLength(13, ErrorMessage = "NID Number is Invalid Size", MinimumLength = 10)]
            public string Mother_NID_Number { get; set; }

            [Required]
            [Display(Name = "Date of Birth")]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
            public DateTime DateOFBirth { get; set; }

            [Required]
            [Display(Name = "Gender")]
            public string Gender { get; set; }

            [Display(Name = "Permanent Address")]
            public string Permanent_Address { get; set; }

            [Required]
            [Display(Name = "Current Address")]
            public string Current_Address { get; set; }

            [Required]
            public string City { get; set; }

            [Required]
            [Display(Name = "Blood Group")]
            public string Blood_Group { get; set; }

            [Display(Name = "NID/Birth Certificate No.")]
            [StringLength(13, ErrorMessage = "NID/Birth Certificate Number is Invalid Size", MinimumLength = 10)]
            public string Identity_Number { get; set; }
            
            [Required]
            [Display(Name = "Occupation")]
            public string Occupation { get; set; }

            [Required]
            [Display(Name = "Maritual Status")]
            public string Maritual_status { get; set; }

            [Required]
            [Display(Name = "Phone Number")]
            [StringLength(11, ErrorMessage = "Invalid Phone number", MinimumLength = 11)]
            public string Phone_Number { get; set; }

            [Required(ErrorMessage = "Please choose profile image")]
            [Display(Name = "Profile Picture")]
            public IFormFile ProfileImage { get; set; }

            public bool isAdmin { get; set; }

            public bool isOrg { get; set; }
            
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

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }
        
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(Input);

                var user = new Users
                {
                    UserName = Input.Email,
                    Email = Input.Email,
                    First_Name = Input.First_Name,
                    Middle_Name = Input.Middle_Name,
                    Last_Name = Input.Last_Name,
                    Fathers_Name = Input.Fathers_Name,
                    Father_NID_Number = Input.Father_NID_Number,
                    Mothers_Name = Input.Mothers_Name,
                    Mother_NID_Number = Input.Mother_NID_Number,
                    DateOfBirth = Input.DateOFBirth,
                    Permanent_Address = Input.Permanent_Address,
                    Current_Address = Input.Current_Address,
                    Gender = Input.Gender,
                    City = Input.City,
                    Blood_Group = Input.Blood_Group,
                    Occupation = Input.Occupation,
                    Maritual_status = Input.Maritual_status,
                    Identity_Number = Input.Identity_Number,
                    PhoneNumber = Input.Phone_Number,
                    ProfilePicture = uniqueFileName,
                    
                };
                
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    if (!await _roleManager.RoleExistsAsync(Static_Details.AdminUser))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(Static_Details.AdminUser));
                    }
                    if (!await _roleManager.RoleExistsAsync(Static_Details.PatientUser))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(Static_Details.PatientUser));
                    }
                    if (!await _roleManager.RoleExistsAsync(Static_Details.DoctorUser))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(Static_Details.DoctorUser));
                    }
                    if (!await _roleManager.RoleExistsAsync(Static_Details.OrgUser))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(Static_Details.OrgUser));
                    } 
                    
                    if (Input.Occupation == "Doctor")
                    {
                        await _userManager.AddToRoleAsync(user, Static_Details.DoctorUser);

                        var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                        var callbackUrl = Url.Page(
                            "/Account/ConfirmEmail",
                            pageHandler: null,
                            values: new { area = "Identity", userId = user.Id, code, returnUrl },
                            protocol: Request.Scheme);

                        await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                            $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");
                    }
                    else if(Input.isAdmin)
                    {
                        await _userManager.AddToRoleAsync(user, Static_Details.AdminUser);
                        
                        var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                        var callbackUrl = Url.Page(
                            "/Account/ConfirmEmail",
                            pageHandler: null,
                            values: new { area = "Identity", userId = user.Id, code, returnUrl },
                            protocol: Request.Scheme);

                        await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                            $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");
                    }
                    else if (Input.isOrg)
                    {
                        await _userManager.AddToRoleAsync(user, Static_Details.OrgUser);

                        var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                        var callbackUrl = Url.Page(
                            "/Account/ConfirmEmail",
                            pageHandler: null,
                            values: new { area = "Identity", userId = user.Id, code, returnUrl },
                            protocol: Request.Scheme);

                        await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                            $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");
                    }
                    else
                    {
                        await _userManager.AddToRoleAsync(user, Static_Details.PatientUser);

                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }

                    _logger.LogInformation("User created a new account with password.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            // If we got this far, something failed, redisplay form
            return Page();
        }     
    }
}
