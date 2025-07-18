using Microsoft.EntityFrameworkCore;
using PersonalNutritionist.Domain.Interfaces.Repositories;
using PersonalNutritionist.Domain.Models.PersonalCard;

namespace PersonalNutritionist.Persistence.Repositories
{
    public class LifestyleRepository : ILifestyleRepository
    {
        private readonly ApplicationDbContext _context;

        public LifestyleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Lifestyle?> GetByIdAsync(Guid id)
        {
            return await _context.Lifestyles.FindAsync(id);
        }

        public async Task<Lifestyle?> GetByPersonCardIdAsync(Guid personCardId)
        {
            return await _context.Lifestyles.FirstOrDefaultAsync(l => l.PersonCardId == personCardId);
        }

        public async Task<IEnumerable<Lifestyle>> GetAllAsync()
        {
            return await _context.Lifestyles.ToListAsync();
        }

        public async Task<Lifestyle> CreateAsync(Lifestyle lifestyle)
        {
            _context.Lifestyles.Add(lifestyle);
            return lifestyle;
        }

        public async Task<Lifestyle> UpdateAsync(Lifestyle lifestyle)
        {
            _context.Lifestyles.Update(lifestyle);
            return lifestyle;
        }

        public async Task DeleteAsync(Guid id)
        {
            var lifestyle = await _context.Lifestyles.FindAsync(id);
            if (lifestyle != null)
            {
                _context.Lifestyles.Remove(lifestyle);
            }
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.Lifestyles.AnyAsync(l => l.Id == id);
        }
    }
}
