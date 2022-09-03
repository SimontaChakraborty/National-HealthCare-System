using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using National_Healthcare_System.Data;
using National_Healthcare_System.Models;

namespace National_Healthcare_System.Pages.BloodGroups
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;      
        }

        public string searchBloodGroup { get; set; }

        [BindProperty]
        public List<Users> UserList { get; set; }
        public async Task<IActionResult> OnGetAsync (string searchBloodGroup = null)
        {
            UserList = await _db.User.ToListAsync();

            StringBuilder param = new StringBuilder();

            param.Append("&searchBloodGroup=");
            if (searchBloodGroup != null)
            {
                param.Append(searchBloodGroup);
            }
            if (searchBloodGroup != null)
            {
                UserList = await _db.User.Where(u => u.Blood_Group.ToLower().Contains(searchBloodGroup.ToLower())).ToListAsync();
            }
            return Page();
        }
    }
}