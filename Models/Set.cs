namespace forge_workout_tracker.Models
{
    public class Set
    {
        public int Id { get; set; }
        public int SetOrder { get; set; }
        public int Reps { get; set; }
        public decimal? Weight { get; set; }
        public int WorkoutId { get; set; }
        public int ExerciseId { get; set; }

        // Navigation properties
        public Workout? Workout{ get; set; }
        public Exercise? Exercise{ get; set; }
    }
}