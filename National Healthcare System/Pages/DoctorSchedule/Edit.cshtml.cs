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

namespace National_Healthcare_System.Pages.DoctorSchedule
{
    public class EditModel : PageModel
    {
        private readonly National_Healthcare_System.Data.ApplicationDbContext _context;

        public EditModel(National_Healthcare_System.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Doctor_Schedule Doctor_Schedule { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Doctor_Schedule = await _context.Doctor_Schedule.FirstOrDefaultAsync(m => m.Schedule_Id == id);

            if (Doctor_Schedule == null)
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

            _context.Attach(Doctor_Schedule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Doctor_ScheduleExists(Doctor_Schedule.Schedule_Id))
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

        private bool Doctor_ScheduleExists(int id)
        {
            return _context.Doctor_Schedule.Any(e => e.Schedule_Id == id);
        }
    }
}
