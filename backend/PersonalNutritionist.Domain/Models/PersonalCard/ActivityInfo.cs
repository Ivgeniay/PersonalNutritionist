

using PersonalNutritionist.Domain.Models.Enums;

namespace PersonalNutritionist.Domain.Models.PersonalCard
{
    public class ActivityInfo
    {
        public Guid Id { get; set; }
        public Guid PersonCardId { get; set; }
        public ProfessionalActivity ProfessionalActivity { get; set; }
        public WorkoutFrequency WorkoutFrequency { get; set; }
        public WorkoutIntensity WorkoutIntensity { get; set; }
        public PhysicalActivityType PhysicalActivityType { get; set; }
        public ActivityLevel DailyActivityLevel { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        
        public PersonCard? PersonCard { get; set; }
    }
}