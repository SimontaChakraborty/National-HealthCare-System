using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using National_Healthcare_System.Data;
using National_Healthcare_System.Models;

namespace National_Healthcare_System.Pages.Diagnostics
{
    public class DeleteModel : PageModel
    {
        private readonly National_Healthcare_System.Data.ApplicationDbContext _context;

        public DeleteModel(National_Healthcare_System.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Diagnostic Diagnostic { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Diagnostic = await _context.Diagnostic.FirstOrDefaultAsync(m => m.Diagnostic_Id == id);

            if (Diagnostic == null)
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

            Diagnostic = await _context.Diagnostic.FindAsync(id);

            if (Diagnostic != null)
            {
                _context.Diagnostic.Remove(Diagnostic);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
