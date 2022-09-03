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

namespace National_Healthcare_System.Pages.Views.ViewDoctorList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;          
        }

        public IList<Doctor> Doctors { get;set; }

        public IList<Users> UserList { get; set; }

        public async Task OnGetAsync()
        {
            UserList = await _context.User.ToListAsync();
            Doctors = await _context.Doctor.ToListAsync();
        }
    }
}
