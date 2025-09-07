using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDBContext _db;
        public UsersController(ApplicationDBContext db) => _db = db;
        public IActionResult Index()
        {
            //var users = _db.Users.ToList();
            List<Users> users = _db.Users.ToList();
            return View(users);
        }
       
    }
}
