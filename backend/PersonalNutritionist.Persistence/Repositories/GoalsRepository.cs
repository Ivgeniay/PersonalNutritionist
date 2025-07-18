using Microsoft.EntityFrameworkCore;
using PersonalNutritionist.Domain.Interfaces.Repositories;
using PersonalNutritionist.Domain.Models.PersonalCard;

namespace PersonalNutritionist.Persistence.Repositories
{
    public class GoalsRepository : IGoalsRepository
    {
        private readonly ApplicationDbContext _context;

        public GoalsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Goals?> GetByIdAsync(Guid id)
        {
            return await _context.Goals.FindAsync(id);
        }

        public async Task<Goals?> GetByPersonCardIdAsync(Guid personCardId)
        {
            return await _context.Goals.FirstOrDefaultAsync(g => g.PersonCardId == personCardId);
        }

        public async Task<IEnumerable<Goals>> GetAllAsync()
        {
            return await _context.Goals.ToListAsync();
        }

        public async Task<Goals> CreateAsync(Goals goals)
        {
            _context.Goals.Add(goals);
            return goals;
        }

        public async Task<Goals> UpdateAsync(Goals goals)
        {
            _context.Goals.Update(goals);
            return goals;
        }

        public async Task DeleteAsync(Guid id)
        {
            var goals = await _context.Goals.FindAsync(id);
            if (goals != null)
            {
                _context.Goals.Remove(goals);
            }
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.Goals.AnyAsync(g => g.Id == id);
        }
    }
}
