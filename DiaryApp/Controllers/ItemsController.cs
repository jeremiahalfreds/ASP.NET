using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Index()
        {
            var item = new Item("Connect Liberia") { Id = Guid.NewGuid() };
            return View(item);
        }
    }
}
