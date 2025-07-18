using PersonalNutritionist.Domain.Models.Entities;
using PersonalNutritionist.Domain.Models.Enums;

namespace PersonalNutritionist.Domain.Models.PersonalCard
{
    public class PersonCard
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
        public Gender Gender { get; set; }


        public PhysicalParameters? PhysicalParameters { get; set; }
        public Goals? Goals { get; set; }
        public ActivityInfo? ActivityInfo { get; set; }
        public MedicalInfo? MedicalInfo { get; set; }
        public NutritionHabits? NutritionHabits { get; set; }
        public Lifestyle? Lifestyle { get; set; }


        public User? User { get; set; }
    }
}