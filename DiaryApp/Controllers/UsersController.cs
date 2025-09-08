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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Users users)
        {
            if (ModelState.IsValid)
            {
                _db.Users.Add(users); // Adds the new diary entry to the db
                _db.SaveChanges(); // Saves the changes to the db
                return RedirectToAction("Index");
            }

            return View(users);
        }

    }
}
