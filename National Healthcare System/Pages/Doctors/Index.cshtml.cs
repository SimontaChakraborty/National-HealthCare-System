using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using National_Healthcare_System.Data;
using National_Healthcare_System.Models;
using National_Healthcare_System.Utility;

namespace National_Healthcare_System.Pages.Doctors
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<IdentityUser> _userManager;

        public IndexModel(ApplicationDbContext context,
                        UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [BindProperty]
        public Doctor Doctor { get; set; }

        public async Task OnGet()
        {
            if(User.IsInRole(Static_Details.DoctorUser))
            {try
                {
                var user = await _userManager.GetUserAsync(HttpContext.User);
                //Gets Users further details are retrieved
                var userFromDb = await _context.User.FirstOrDefaultAsync(u => u.Email == user.Email);
                //Retrieves current doctors doctor_Id
                var currentDoctor = await _context.Doctor.Where(d => d.Identity_Number == userFromDb.Identity_Number).FirstOrDefaultAsync();
                //LINQ query that gets the Consultation data which match with Doctors doctor_id.
                Doctor = await _context.Doctor.FirstOrDefaultAsync(c => c.Identity_Number == currentDoctor.Identity_Number);
                }
                catch { Exception ex; }
            }
        }
    }
}
