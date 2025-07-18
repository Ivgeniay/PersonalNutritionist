using PersonalNutritionist.Domain.Models.Entities;

namespace PersonalNutritionist.Domain.Models.Auth
{
    public class TelegramAuth
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public long TelegramId { get; set; }
        public string TelegramUsername { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
        
        public User? User { get; set; }
    }
}