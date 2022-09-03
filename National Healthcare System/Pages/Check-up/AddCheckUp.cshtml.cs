using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using National_Healthcare_System.Data;
using National_Healthcare_System.Models;

namespace National_Healthcare_System.Pages.Check_up
{
    public class AddCheckUpModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public AddCheckUpModel(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }   

        //generating Unique values
        public Guid conID = Guid.NewGuid();
        public Guid preID = Guid.NewGuid();
        public Guid medID = Guid.NewGuid();

        //Objects of Models

        public Doctor currentDoctor { get; set; }
        [BindProperty]
        public Consultation Consultation { get; set; }
        [BindProperty]
        public Prescription Prescription { get; set; }
        [BindProperty]
        public Medication Medication { get; set; }

        public async Task OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var userFromDb = await _context.User.FirstOrDefaultAsync(u => u.Email == user.Email);
            currentDoctor = await _context.Doctor.FirstOrDefaultAsync(d => d.Identity_Number == userFromDb.Identity_Number);
        }

        //Form Submission
        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Saving to database
            _context.Consultation.AddAsync(Consultation);
            await _context.SaveChangesAsync();

            _context.Prescription.AddAsync(Prescription);
            await _context.SaveChangesAsync();

            _context.Medication.AddAsync(Medication);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Consultations/Index");
        }

    }
}
