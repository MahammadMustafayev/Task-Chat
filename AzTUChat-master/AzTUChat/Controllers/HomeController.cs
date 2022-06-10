using AzTUChat.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AzTUChat.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Users.Include(u=>u.Image));
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
