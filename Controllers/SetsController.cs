using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using forge_workout_tracker.Data;
using forge_workout_tracker.Models;

namespace forge_workout_tracker.Controllers
{
    public class SetsController : Controller
    {
        private readonly ForgeDbContext _context;

        public SetsController(ForgeDbContext context)
        {
            _context = context;
        }

        public IActionResult Create(int workoutId)
        {
            ViewBag.WorkoutId = workoutId;
            ViewBag.Exercises = new SelectList(_context.Exercises, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Set set)
        {
            _context.Sets.Add(set);
            _context.SaveChanges();
            return RedirectToAction("Details", "Workouts", new { id = set.WorkoutId });
        }
    }
}