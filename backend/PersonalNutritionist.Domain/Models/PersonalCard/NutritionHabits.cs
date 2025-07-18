using PersonalNutritionist.Domain.Models.Enums;

namespace PersonalNutritionist.Domain.Models.PersonalCard
{
    public class NutritionHabits
    {
        public Guid Id { get; set; }
        public Guid PersonCardId { get; set; }
        public string CurrentDiet { get; set; } = string.Empty;
        public string FoodPreferences { get; set; } = string.Empty;
        public MealPattern MealPattern { get; set; }
        public AlcoholConsumption AlcoholConsumption { get; set; }
        public decimal DailyWaterIntake { get; set; }
        public string SupplementsAndVitamins { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        
        public PersonCard? PersonCard { get; set; }
    }
}