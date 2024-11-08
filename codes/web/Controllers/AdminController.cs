using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using web.Data;

namespace web.Controllers
{
    // Controllers/AdminController.cs
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> ActivityLogs()
        {
            var logs = await _context.ActivityLogs.OrderByDescending(log => log.AccessedAt).ToListAsync();
            return View(logs);
        }
    }

}
