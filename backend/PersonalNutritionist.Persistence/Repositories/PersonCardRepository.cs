using Microsoft.EntityFrameworkCore;
using PersonalNutritionist.Domain.Interfaces.Repositories;
using PersonalNutritionist.Domain.Models.PersonalCard;

namespace PersonalNutritionist.Persistence.Repositories
{
    public class PersonCardRepository : IPersonCardRepository
    {
        private readonly ApplicationDbContext _context;

        public PersonCardRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PersonCard?> GetByIdAsync(Guid id)
        {
            return await _context.PersonCards.FindAsync(id);
        }

        public async Task<IEnumerable<PersonCard>> GetAllAsync()
        {
            return await _context.PersonCards.ToListAsync();
        }

        public async Task<IEnumerable<PersonCard>> GetByUserIdAsync(Guid userId)
        {
            return await _context.PersonCards.Where(p => p.UserId == userId).ToListAsync();
        }

        public async Task<PersonCard> CreateAsync(PersonCard personCard)
        {
            _context.PersonCards.Add(personCard);
            return personCard;
        }

        public async Task<PersonCard> UpdateAsync(PersonCard personCard)
        {
            _context.PersonCards.Update(personCard);
            return personCard;
        }

        public async Task DeleteAsync(Guid id)
        {
            var personCard = await _context.PersonCards.FindAsync(id);
            if (personCard != null)
            {
                _context.PersonCards.Remove(personCard);
            }
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.PersonCards.AnyAsync(p => p.Id == id);
        }
    }
}
