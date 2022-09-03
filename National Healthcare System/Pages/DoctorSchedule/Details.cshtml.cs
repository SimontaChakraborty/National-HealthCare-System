using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using National_Healthcare_System.Data;
using National_Healthcare_System.Models;
using National_Healthcare_System.Utility;

namespace National_Healthcare_System.Pages.DoctorSchedule
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Doctor_Schedule Doctor_Schedule { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id, int? sID)
        {   
            if((User.IsInRole(Static_Details.DoctorUser) || User.IsInRole(Static_Details.AdminUser)) && sID != null)
            {
                if (sID == null)
                {
                    return NotFound();
                }

                Doctor_Schedule = await _context.Doctor_Schedule.FirstOrDefaultAsync(m => m.Schedule_Id == sID);

                if (Doctor_Schedule == null)
                {
                    return NotFound();
                }
                return Page();
            }
            else
            {
                if (id == null)
                {
                    return NotFound();
                }

                Doctor_Schedule = await _context.Doctor_Schedule.FirstOrDefaultAsync(m => m.Doctor_Id == id);

                if (Doctor_Schedule == null)
                {
                    return NotFound();
                }
                return Page();
            }
            
        }
    }
}
