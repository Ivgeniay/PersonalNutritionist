using PersonalNutritionist.Domain.Models.PersonalCard;

namespace PersonalNutritionist.Domain.Interfaces.Repositories
{
    public interface IPhysicalParametersRepository
    {
        Task<PhysicalParameters?> GetByIdAsync(Guid id);
        Task<PhysicalParameters?> GetByPersonCardIdAsync(Guid personCardId);
        Task<IEnumerable<PhysicalParameters>> GetAllAsync();
        Task<PhysicalParameters> CreateAsync(PhysicalParameters physicalParameters);
        Task<PhysicalParameters> UpdateAsync(PhysicalParameters physicalParameters);
        Task DeleteAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
    }
}
