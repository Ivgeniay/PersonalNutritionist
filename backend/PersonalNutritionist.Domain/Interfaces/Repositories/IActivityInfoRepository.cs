using PersonalNutritionist.Domain.Models.PersonalCard;

namespace PersonalNutritionist.Domain.Interfaces.Repositories
{
    public interface IActivityInfoRepository
    {
        Task<ActivityInfo?> GetByIdAsync(Guid id);
        Task<ActivityInfo?> GetByPersonCardIdAsync(Guid personCardId);
        Task<IEnumerable<ActivityInfo>> GetAllAsync();
        Task<ActivityInfo> CreateAsync(ActivityInfo activityInfo);
        Task<ActivityInfo> UpdateAsync(ActivityInfo activityInfo);
        Task DeleteAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
    }
}
