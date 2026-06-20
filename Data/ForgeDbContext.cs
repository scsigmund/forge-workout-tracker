using Microsoft.EntityFrameworkCore;
using forge_workout_tracker.Models;

namespace forge_workout_tracker.Data
{
    public class ForgeDbContext : DbContext
    {
        public ForgeDbContext(DbContextOptions<ForgeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Workout> Workouts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Set>()
                .Property(s => s.Weight)
                .HasPrecision(6, 2);
        }
    }
}