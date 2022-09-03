using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using National_Healthcare_System.Data;
using National_Healthcare_System.Models;

namespace National_Healthcare_System.Pages.Organizations
{
    public class DeleteModel : PageModel
    {
        private readonly National_Healthcare_System.Data.ApplicationDbContext _context;

        public DeleteModel(National_Healthcare_System.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Organization Organization { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Organization = await _context.Organization.FirstOrDefaultAsync(m => m.Organization_Id == id);

            if (Organization == null)
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

            Organization = await _context.Organization.FindAsync(id);

            if (Organization != null)
            {
                _context.Organization.Remove(Organization);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
