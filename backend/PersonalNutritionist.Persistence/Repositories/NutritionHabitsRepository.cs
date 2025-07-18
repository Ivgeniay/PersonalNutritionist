using Microsoft.EntityFrameworkCore;
using PersonalNutritionist.Domain.Interfaces.Repositories;
using PersonalNutritionist.Domain.Models.PersonalCard;

namespace PersonalNutritionist.Persistence.Repositories
{
    public class NutritionHabitsRepository : INutritionHabitsRepository
    {
        private readonly ApplicationDbContext _context;

        public NutritionHabitsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<NutritionHabits?> GetByIdAsync(Guid id)
        {
            return await _context.NutritionHabits.FindAsync(id);
        }

        public async Task<NutritionHabits?> GetByPersonCardIdAsync(Guid personCardId)
        {
            return await _context.NutritionHabits.FirstOrDefaultAsync(n => n.PersonCardId == personCardId);
        }

        public async Task<IEnumerable<NutritionHabits>> GetAllAsync()
        {
            return await _context.NutritionHabits.ToListAsync();
        }

        public async Task<NutritionHabits> CreateAsync(NutritionHabits nutritionHabits)
        {
            _context.NutritionHabits.Add(nutritionHabits);
            return nutritionHabits;
        }

        public async Task<NutritionHabits> UpdateAsync(NutritionHabits nutritionHabits)
        {
            _context.NutritionHabits.Update(nutritionHabits);
            return nutritionHabits;
        }

        public async Task DeleteAsync(Guid id)
        {
            var nutritionHabits = await _context.NutritionHabits.FindAsync(id);
            if (nutritionHabits != null)
            {
                _context.NutritionHabits.Remove(nutritionHabits);
            }
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.NutritionHabits.AnyAsync(n => n.Id == id);
        }
    }
}
