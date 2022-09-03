using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using National_Healthcare_System.Data;
using National_Healthcare_System.Models;

namespace National_Healthcare_System.Pages.Consultations
{
    public class DeleteModel : PageModel
    {
        private readonly National_Healthcare_System.Data.ApplicationDbContext _context;

        public DeleteModel(National_Healthcare_System.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Consultation Consultation { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Consultation = await _context.Consultation.FirstOrDefaultAsync(m => m.Consultation_Id == id);

            if (Consultation == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Consultation = await _context.Consultation.FindAsync(id);

            if (Consultation != null)
            {
                _context.Consultation.Remove(Consultation);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
