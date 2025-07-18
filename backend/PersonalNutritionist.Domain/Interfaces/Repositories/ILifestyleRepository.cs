using PersonalNutritionist.Domain.Models.PersonalCard;

namespace PersonalNutritionist.Domain.Interfaces.Repositories
{
    public interface ILifestyleRepository
    {
        Task<Lifestyle?> GetByIdAsync(Guid id);
        Task<Lifestyle?> GetByPersonCardIdAsync(Guid personCardId);
        Task<IEnumerable<Lifestyle>> GetAllAsync();
        Task<Lifestyle> CreateAsync(Lifestyle lifestyle);
        Task<Lifestyle> UpdateAsync(Lifestyle lifestyle);
        Task DeleteAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
    }
}
