using PersonalNutritionist.Domain.Models.PersonalCard;
using PersonalNutritionist.Domain.Models.Auth;

namespace PersonalNutritionist.Domain.Models.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }

        public ICollection<PersonCard> People { get; set; } = new List<PersonCard>();
        public LoginPasswordAuth? LoginPasswordAuth { get; set; } 
        public TelegramAuth? TelegramAuth { get; set; }
    }
}