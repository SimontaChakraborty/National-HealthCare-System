using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using National_Healthcare_System.Data;
using National_Healthcare_System.Models;

namespace National_Healthcare_System.Pages.Medications
{
    [Authorize(Roles ="Doctor, Organization")]
    public class AddMedicationModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public AddMedicationModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Medication Medication { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.Medication.AddAsync(Medication);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
