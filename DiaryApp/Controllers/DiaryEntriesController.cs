using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Configuration;


namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private ApplicationDBContext _context;
        public DiaryEntriesController(ApplicationDBContext context) 
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var diaryEntry = _context.DiaryEntries.ToList();
            return View(diaryEntry);
        }
        public IActionResult Create() 
        {
            return View();
        }
    }
}
