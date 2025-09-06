using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Configuration;


namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDBContext _db;
        public DiaryEntriesController(ApplicationDBContext db) 
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var entries = _db.DiaryEntries.ToList();
            //List<DiaryEntry> entries = _db.DiaryEntries.ToList();
            return View(entries);
        }
        public IActionResult Create() 
        {
            return View();
        }
    }
}
