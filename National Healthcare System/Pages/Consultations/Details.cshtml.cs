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
    public class DetailsModel : PageModel
    {
        private readonly National_Healthcare_System.Data.ApplicationDbContext _context;

        public DetailsModel(National_Healthcare_System.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
