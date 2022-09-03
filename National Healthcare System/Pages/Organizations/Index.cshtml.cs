using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using National_Healthcare_System.Data;
using National_Healthcare_System.Models;

namespace National_Healthcare_System.Pages.Organizations
{
    public class IndexModel : PageModel
    {
        private readonly National_Healthcare_System.Data.ApplicationDbContext _context;

        public IndexModel(National_Healthcare_System.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Organization> Organization { get;set; }

        public async Task OnGetAsync()
        {
            Organization = await _context.Organization.ToListAsync();
        }
    }
}
