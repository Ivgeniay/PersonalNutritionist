using PersonalNutritionist.Domain.Models.PersonalCard;

namespace PersonalNutritionist.Domain.Interfaces.Repositories
{
    public interface IGoalsRepository
    {
        Task<Goals?> GetByIdAsync(Guid id);
        Task<Goals?> GetByPersonCardIdAsync(Guid personCardId);
        Task<IEnumerable<Goals>> GetAllAsync();
        Task<Goals> CreateAsync(Goals goals);
        Task<Goals> UpdateAsync(Goals goals);
        Task DeleteAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
    }
}
