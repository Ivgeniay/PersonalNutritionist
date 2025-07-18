using PersonalNutritionist.Domain.Models.Enums;

namespace PersonalNutritionist.Domain.Models.PersonalCard
{
    public class Lifestyle
    {
        public Guid Id { get; set; }
        public Guid PersonCardId { get; set; }
        public int SleepHours { get; set; }
        public StressLevel StressLevel { get; set; }
        public string SocialFactors { get; set; } = string.Empty;
        public decimal FoodBudget { get; set; }
        public int CookingTimeAvailable { get; set; }
        public CookingSkills CookingSkills { get; set; }
        public string PreviousDietExperience { get; set; } = string.Empty;
        public string PsychologicalRelationshipWithFood { get; set; } = string.Empty;
        public int MotivationLevel { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        
        public PersonCard? PersonCard { get; set; }
    }
}