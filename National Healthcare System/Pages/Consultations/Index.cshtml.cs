using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using National_Healthcare_System.Data;
using National_Healthcare_System.Models;
using National_Healthcare_System.Utility;


namespace National_Healthcare_System.Pages.Consultations
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public IndexModel(UserManager<IdentityUser> userManager,
        ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public List<Consultation> Consultation { get; set; }

        public async Task OnGetAsync()
        {
            if (User.IsInRole(Static_Details.PatientUser))
            {
                //this line gets Current Users data
                var user = await _userManager.GetUserAsync(HttpContext.User);
                //with this line Users further details are retrieved
                var userFromDb = await _context.User.FirstOrDefaultAsync(u => u.Email == user.Email);
                //This is LINQ query. This line Gets the Consultation data which match with Users details.
                Consultation = await _context.Consultation.Where(c => c.Identity_Number == userFromDb.Identity_Number).ToListAsync();
            }
            else if (User.IsInRole(Static_Details.DoctorUser))
            {
                //gets Current Users data
                var user = await _userManager.GetUserAsync(HttpContext.User);
                //Gets Users further details are retrieved
                var userFromDb = await _context.User.FirstOrDefaultAsync(u => u.Email == user.Email);
                //Retrieves current doctors doctor_Id
                var currentDoctor = await _context.Doctor.Where(d => d.Identity_Number == userFromDb.Identity_Number).FirstOrDefaultAsync();
                //LINQ query that gets the Consultation data which match with Doctors doctor_id.
                Consultation = await _context.Consultation.Where(c => c.Doctor_Id == currentDoctor.Doctor_Id).ToListAsync();
            }
            else if (User.IsInRole(Static_Details.AdminUser))
            {
                //Full consultation table is retrieved
                Consultation = await _context.Consultation.ToListAsync();
            }
        }
    }
}

