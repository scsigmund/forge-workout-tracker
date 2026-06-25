using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using forge_workout_tracker.Data;
using forge_workout_tracker.Models;

namespace forge_workout_tracker.Controllers
{
    public class WorkoutsController : Controller
    {
        private readonly ForgeDbContext _context;

        public WorkoutsController(ForgeDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var workouts = _context.Workouts.ToList();
            return View(workouts);
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Workout workout)
        {
            workout.UserId = 1; // hardcoded placeholder until auth
            workout.StartDateTime = DateTime.Now;
            _context.Workouts.Add(workout);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}