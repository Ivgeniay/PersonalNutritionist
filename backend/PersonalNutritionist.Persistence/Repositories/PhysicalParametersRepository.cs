using Microsoft.EntityFrameworkCore;
using PersonalNutritionist.Domain.Interfaces.Repositories;
using PersonalNutritionist.Domain.Models.PersonalCard;


namespace PersonalNutritionist.Persistence.Repositories
{
    public class PhysicalParametersRepository : IPhysicalParametersRepository
    {
        private readonly ApplicationDbContext _context;

        public PhysicalParametersRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PhysicalParameters?> GetByIdAsync(Guid id)
        {
            return await _context.PhysicalParameters.FindAsync(id);
        }

        public async Task<PhysicalParameters?> GetByPersonCardIdAsync(Guid personCardId)
        {
            return await _context.PhysicalParameters.FirstOrDefaultAsync(p => p.PersonCardId == personCardId);
        }

        public async Task<IEnumerable<PhysicalParameters>> GetAllAsync()
        {
            return await _context.PhysicalParameters.ToListAsync();
        }

        public async Task<PhysicalParameters> CreateAsync(PhysicalParameters physicalParameters)
        {
            _context.PhysicalParameters.Add(physicalParameters);
            return physicalParameters;
        }

        public async Task<PhysicalParameters> UpdateAsync(PhysicalParameters physicalParameters)
        {
            _context.PhysicalParameters.Update(physicalParameters);
            return physicalParameters;
        }

        public async Task DeleteAsync(Guid id)
        {
            var physicalParameters = await _context.PhysicalParameters.FindAsync(id);
            if (physicalParameters != null)
            {
                _context.PhysicalParameters.Remove(physicalParameters);
            }
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.PhysicalParameters.AnyAsync(p => p.Id == id);
        }
    }
}
