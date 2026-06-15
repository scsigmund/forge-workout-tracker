namespace forge_workout_tracker.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public required string Name {get; set; }
        public string? MuscleGroup { get; set; }
    }
}