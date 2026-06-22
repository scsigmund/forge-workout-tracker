using Microsoft.AspNetCore.Mvc;
using forge_workout_tracker.Data;
using forge_workout_tracker.Models;

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
    }
}