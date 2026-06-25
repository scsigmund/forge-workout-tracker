using Microsoft.AspNetCore.Mvc;
using forge_workout_tracker.Data;
using forge_workout_tracker.Models;
using AspNetCoreGeneratedDocument;

namespace forge_workout_tracker.Controllers
{
    public class ExercisesController : Controller
    {
        private readonly ForgeDbContext _context;

        public ExercisesController(ForgeDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var exercises = _context.Exercises.ToList();
            return View(exercises);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Exercise exercise)
        {
            _context.Exercises.Add(exercise);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var exercise = _context.Exercises.Find(id);
            if (exercise == null) return NotFound();
            return View(exercise);
        }

        [HttpPost]
        public IActionResult Edit(Exercise exercise)
        {
            _context.Exercises.Update(exercise);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var exercise = _context.Exercises.Find(id);
            if (exercise == null) return NotFound();
            _context.Exercises.Remove(exercise);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}