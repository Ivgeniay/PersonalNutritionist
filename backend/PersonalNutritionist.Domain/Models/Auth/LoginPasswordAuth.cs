using PersonalNutritionist.Domain.Models.Entities;

namespace PersonalNutritionist.Domain.Models.Auth
{
    public class LoginPasswordAuth
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
        
        public User? User { get; set; }
    }
}