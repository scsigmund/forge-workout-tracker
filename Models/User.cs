namespace forge_workout_tracker.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Name {get; set; }
        public required string Email { get; set;}
        public required string Username { get; set; }
        public required string PasswordHash { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? PhoneNumber { get; set; }
    }
}