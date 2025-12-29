using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Configuration;


namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDBContext _db;
        public DiaryEntriesController(ApplicationDBContext db) => _db = db;

        public IActionResult Index()
        {
            var entries = _db.DiaryEntries.ToList();
            //List<DiaryEntry> entries = _db.DiaryEntries.ToList();
            Console.WriteLine("Retrieved diary entries: " + entries.Count);

            return View(entries);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DiaryEntry diary)
        {
            // check validation
            if (diary != null && diary.Title.Length < 5) 
            {
                ModelState.AddModelError("Title", "Title must be between 3 and 100 characters.");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Add(diary); // Adds the new diary entry to the db
                _db.SaveChanges(); // Saves the changes to the db
                return RedirectToAction("Index");
            }

            TempData["Error"] = "Insufficient Privileges";
            return View(diary);
        }

        [HttpGet]
        public IActionResult Edit(int? id ) 
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);

            if(diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Edit(DiaryEntry diary)
        {
            // check validation
            if (diary != null && diary.Title.Length < 5)
            {
                ModelState.AddModelError("Title", "Title must be between 3 and 100 characters.");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Update(diary); // Updates the new diary entry in the db
                _db.SaveChanges(); // Saves the changes to the db
                return RedirectToAction("Index");
            }

            return View(diary);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);

            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Delete(DiaryEntry diary)
        {
            _db.DiaryEntries.Remove(diary); // Updates the new diary entry in the db
            _db.SaveChanges(); // Saves the changes to the db
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Show(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);

            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }
    }
}
