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

namespace National_Healthcare_System.Pages.DoctorSchedule
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
#nullable enable
        public IList<Doctor_Schedule>? Doctor_Schedule { get;set; }

        public async Task OnGetAsync()
        {
            try {
                var user = await _userManager.GetUserAsync(HttpContext.User);
                var userFromDb = await _context.User.FirstOrDefaultAsync(u => u.Email == user.Email);
                var currentDoctor = await _context.Doctor.FirstOrDefaultAsync(d => d.Identity_Number == userFromDb.Identity_Number);
                Doctor_Schedule = await _context.Doctor_Schedule.Where(s => s.Doctor_Id == currentDoctor.Doctor_Id).ToListAsync();
            }
            catch { Exception x;}

            
        }
    }
}
