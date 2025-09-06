using DiaryApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDBContext _context;
        public UsersController(ApplicationDBContext context) 
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            return View(users);
        }
    }
}
