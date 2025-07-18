using PersonalNutritionist.Domain.Models.Enums;

namespace PersonalNutritionist.Domain.Models.PersonalCard
{
    public class Goals
    {
        public Guid Id { get; set; }
        public Guid PersonCardId { get; set; }
        public decimal? DesiredWeight { get; set; }
        public string DesiredBodyChanges { get; set; } = string.Empty;
        public DateTime? TargetDate { get; set; }
        public GoalPriority Priority { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        
        public PersonCard? PersonCard { get; set; }
    }
}