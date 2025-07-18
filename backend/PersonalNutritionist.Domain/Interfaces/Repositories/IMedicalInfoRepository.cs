using PersonalNutritionist.Domain.Models.PersonalCard;

namespace PersonalNutritionist.Domain.Interfaces.Repositories
{
    public interface IMedicalInfoRepository
    {
        Task<MedicalInfo?> GetByIdAsync(Guid id);
        Task<MedicalInfo?> GetByPersonCardIdAsync(Guid personCardId);
        Task<IEnumerable<MedicalInfo>> GetAllAsync();
        Task<MedicalInfo> CreateAsync(MedicalInfo medicalInfo);
        Task<MedicalInfo> UpdateAsync(MedicalInfo medicalInfo);
        Task DeleteAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
    }
}
