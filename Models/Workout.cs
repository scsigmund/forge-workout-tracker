namespace forge_workout_tracker.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public int UserId { get; set; }

        // Navigation properties
        public User? User{ get; set; }
        public List<Set> Sets { get; set; } = new();
    }
}