using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using National_Healthcare_System.Data;
using National_Healthcare_System.Models;

namespace National_Healthcare_System.Pages.AllUsers
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public IList<Users> UsersList { get; set; }
        public async Task<IActionResult> OnGet(string searchEmail = null)
        {
            UsersList = await _db.User.ToListAsync();

            StringBuilder param = new StringBuilder();

           /* param.Append("&searchName=");
            if (searchName != null)
            {
                param.Append(searchName);
            }*/
            param.Append("&searchEmail=");
            if (searchEmail != null)
            {
                param.Append(searchEmail);
            }
           /* param.Append("&searchPhone=");
            if (searchPhone != null)
            {
                param.Append(searchPhone);
            }*/
            if (searchEmail != null)
            {
                UsersList = await _db.User.Where(u => u.Email.ToLower().Contains(searchEmail.ToLower())).ToListAsync();
            }
           /* else
            {
                if (searchName != null)
                {
                    UsersList = await _db.User.Where(u => u.First_Name.ToLower().Contains(searchName.ToLower())).ToListAsync();
                }
                else
                {
                    if (searchPhone != null)
                    {
                        UsersList = await _db.User.Where(u => u.PhoneNumber.ToLower().Contains(searchPhone.ToLower())).ToListAsync();
                    }
                }
            }*/
            return Page();
        }
    }
}
