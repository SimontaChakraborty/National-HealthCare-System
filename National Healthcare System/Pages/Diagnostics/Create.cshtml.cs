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
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using National_Healthcare_System.Data;
using National_Healthcare_System.Models;

namespace National_Healthcare_System.Pages.Diagnostics
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IWebHostEnvironment webHostEnvironment;

        public CreateModel(ApplicationDbContext context, UserManager<IdentityUser> userManager, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _userManager = userManager;
            webHostEnvironment = hostEnvironment;
        }
        //public string DiagImage { get; set; }  
        public Guid diagId { get; set; } = Guid.NewGuid();
        public InputModel Input { get; set; }

        public class InputModel
        {

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
            [Display(Name = "Diagnostics Image")]
            public IFormFile DigImage { get; set; }

            public string Image { get; set; }
        }
        private string UploadedFile(InputModel Input)
        {
            string uniqueFileName = null;

            if (Input.DigImage != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Diagimages");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Input.DigImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Input.DigImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
        public async Task OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var userFromDb = await _context.User.FirstOrDefaultAsync(u => u.Email == user.Email);
            //DiagImage = userFromDb.ProfilePicture.ToString();

        }

        [BindProperty]
        public Diagnostic Diagnostic { get; set; }       

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            string uniqueFileName = UploadedFile(Input);
            Diagnostic.Diagnostic_Id = diagId;
            Diagnostic.Consultation_Id = Input.Consultation_Id;
            Diagnostic.DateOfDiagnose = Input.DateOfDiagnose;
            Diagnostic.Diagnostic_Type = Input.Diagnostic_Type;
            Diagnostic.Diagnostics = Input.Diagnostics;
            Diagnostic.Organization_Id = Input.Organization_Id;
            Diagnostic.Image = uniqueFileName;





            _context.Diagnostic.Add(Diagnostic);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
