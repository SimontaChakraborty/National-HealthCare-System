using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using National_Healthcare_System.Data;
using System.Security.Claims;
using System.Threading.Tasks;

namespace National_Healthcare_System.ViewComponents
{
    public class UserNameViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _db;

        public UserNameViewComponent(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claims = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            var userFromDb = await _db.Users.FirstOrDefaultAsync(u => u.Id == claims.Value);

            return View(userFromDb);
        }

    }

}
