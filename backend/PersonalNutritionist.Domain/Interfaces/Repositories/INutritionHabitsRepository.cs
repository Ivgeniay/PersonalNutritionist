using PersonalNutritionist.Domain.Models.PersonalCard;

namespace PersonalNutritionist.Domain.Interfaces.Repositories
{
    public interface INutritionHabitsRepository
    {
        Task<NutritionHabits?> GetByIdAsync(Guid id);
        Task<NutritionHabits?> GetByPersonCardIdAsync(Guid personCardId);
        Task<IEnumerable<NutritionHabits>> GetAllAsync();
        Task<NutritionHabits> CreateAsync(NutritionHabits nutritionHabits);
        Task<NutritionHabits> UpdateAsync(NutritionHabits nutritionHabits);
        Task DeleteAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
    }
}
