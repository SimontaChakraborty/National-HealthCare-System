using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using National_Healthcare_System.Data;
using National_Healthcare_System.Models;

namespace National_Healthcare_System.Pages.Prescriptions
{
    public class DetailsModel : PageModel
    {
        private readonly National_Healthcare_System.Data.ApplicationDbContext _context;

        public DetailsModel(National_Healthcare_System.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Prescription Prescription { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Prescription = await _context.Prescription.FirstOrDefaultAsync(m => m.Prescription_Id == id);

            if (Prescription == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
