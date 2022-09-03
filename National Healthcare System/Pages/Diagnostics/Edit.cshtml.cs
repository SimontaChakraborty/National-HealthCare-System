using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using National_Healthcare_System.Data;
using National_Healthcare_System.Models;

namespace National_Healthcare_System.Pages.Diagnostics
{
    public class EditModel : PageModel
    {
        private readonly National_Healthcare_System.Data.ApplicationDbContext _context;

        public EditModel(National_Healthcare_System.Data.ApplicationDbContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Diagnostic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DiagnosticExists(Diagnostic.Diagnostic_Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DiagnosticExists(Guid id)
        {
            return _context.Diagnostic.Any(e => e.Diagnostic_Id == id);
        }
    }
}
