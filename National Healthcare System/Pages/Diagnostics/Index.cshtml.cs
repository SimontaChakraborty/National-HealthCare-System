using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using National_Healthcare_System.Data;
using National_Healthcare_System.Models;
using National_Healthcare_System.Utility;

namespace National_Healthcare_System.Pages.Diagnostics
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IWebHostEnvironment webHostEnvironment;

        public IndexModel(UserManager<IdentityUser> userManager,
            ApplicationDbContext context,
            IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _userManager = userManager;
            webHostEnvironment = hostEnvironment; ;
        }

        public IList<Diagnostic> Diagnostic { get; set; }
        public string DiagImage { get; private set; }

        public async Task OnGetAsync()
        {
            if (User.IsInRole(Static_Details.PatientUser))
            {
                //gets user data
                var user = await _userManager.GetUserAsync(User);
                //syncs user data from database
                var userFromDb = await _context.User.FirstOrDefaultAsync(u => u.Email == user.Email);
                //DiagImage = userFromDb.ProfilePicture.ToString();
                //gets users consutation datas
                var userConsult = await _context.Consultation.FirstOrDefaultAsync(c => c.Identity_Number == userFromDb.Identity_Number);
                //gets diagnostic datas
                try
                {
                    Diagnostic = await _context.Diagnostic.Where(d => d.Consultation_Id == userConsult.Consultation_Id).ToListAsync();
                }
                catch { Exception ex; }
            }
            if (User.IsInRole(Static_Details.DoctorUser))
            {
                //gets user data
                var user = await _userManager.GetUserAsync(User);
                //syncs user data from database
                var userFromDb = await _context.User.FirstOrDefaultAsync(u => u.Email == user.Email);
                //DiagImage = userFromDb.ProfilePicture.ToString();

                var currentDoctor = await _context.Doctor.FirstOrDefaultAsync(d => d.Identity_Number == userFromDb.Identity_Number);
                //gets users consutation datas
                var userConsult = await _context.Consultation.FirstOrDefaultAsync(c => c.Doctor_Id == currentDoctor.Doctor_Id);
                //gets diagnostic datas
                try
                {
                    Diagnostic = await _context.Diagnostic.Where(d => d.Consultation_Id == userConsult.Consultation_Id).ToListAsync();
                }
                catch { Exception ex; }
            }
            if (User.IsInRole(Static_Details.OrgUser))
            {
                //gets user data
                var user = await _userManager.GetUserAsync(User);
                //syncs user data from database
                var userFromDb = await _context.User.FirstOrDefaultAsync(u => u.Email == user.Email);
                //DiagImage = userFromDb.ProfilePicture.ToString();
                //Org user data
                var currentOrg = await _context.Organization.FirstOrDefaultAsync(o => o.Organization_Id.ToString() == userFromDb.Occupation);
                //gets diagnostic datas
                try
                {
                    Diagnostic = await _context.Diagnostic.Where(d => d.Organization_Id == currentOrg.Organization_Id).ToListAsync();
                }
                catch { Exception ex; }
            }
            if (User.IsInRole(Static_Details.AdminUser))
            {
                Diagnostic = await _context.Diagnostic.ToListAsync();
     
            }
        }
    }
}
