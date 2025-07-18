using Microsoft.EntityFrameworkCore;
using PersonalNutritionist.Domain.Interfaces.Repositories;
using PersonalNutritionist.Domain.Models.PersonalCard;

namespace PersonalNutritionist.Persistence.Repositories
{
    public class MedicalInfoRepository : IMedicalInfoRepository
    {
        private readonly ApplicationDbContext _context;

        public MedicalInfoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<MedicalInfo?> GetByIdAsync(Guid id)
        {
            return await _context.MedicalInfos.FindAsync(id);
        }

        public async Task<MedicalInfo?> GetByPersonCardIdAsync(Guid personCardId)
        {
            return await _context.MedicalInfos.FirstOrDefaultAsync(m => m.PersonCardId == personCardId);
        }

        public async Task<IEnumerable<MedicalInfo>> GetAllAsync()
        {
            return await _context.MedicalInfos.ToListAsync();
        }

        public async Task<MedicalInfo> CreateAsync(MedicalInfo medicalInfo)
        {
            _context.MedicalInfos.Add(medicalInfo);
            return medicalInfo;
        }

        public async Task<MedicalInfo> UpdateAsync(MedicalInfo medicalInfo)
        {
            _context.MedicalInfos.Update(medicalInfo);
            return medicalInfo;
        }

        public async Task DeleteAsync(Guid id)
        {
            var medicalInfo = await _context.MedicalInfos.FindAsync(id);
            if (medicalInfo != null)
            {
                _context.MedicalInfos.Remove(medicalInfo);
            }
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.MedicalInfos.AnyAsync(m => m.Id == id);
        }
    }
}
