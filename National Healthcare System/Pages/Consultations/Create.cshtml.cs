using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using National_Healthcare_System.Data;
using National_Healthcare_System.Models;

namespace National_Healthcare_System.Pages.Consultations
{
    public class CreateModel : PageModel
    {
        private readonly National_Healthcare_System.Data.ApplicationDbContext _context;

        public CreateModel(National_Healthcare_System.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Consultation Consultation { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Consultation.Add(Consultation);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
