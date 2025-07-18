using PersonalNutritionist.Domain.Models.PersonalCard;

namespace PersonalNutritionist.Domain.Interfaces.Repositories
{
    public interface IPersonCardRepository
    {
        Task<PersonCard?> GetByIdAsync(Guid id);
        Task<IEnumerable<PersonCard>> GetAllAsync();
        Task<IEnumerable<PersonCard>> GetByUserIdAsync(Guid userId);
        Task<PersonCard> CreateAsync(PersonCard personCard);
        Task<PersonCard> UpdateAsync(PersonCard personCard);
        Task DeleteAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
    }
}
