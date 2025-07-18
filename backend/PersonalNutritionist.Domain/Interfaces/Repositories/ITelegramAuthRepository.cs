using PersonalNutritionist.Domain.Models.Auth;

namespace PersonalNutritionist.Domain.Interfaces.Repositories
{
    public interface ITelegramAuthRepository
    {
        Task<TelegramAuth?> GetByIdAsync(Guid id);
        Task<TelegramAuth?> GetByUserIdAsync(Guid userId);
        Task<TelegramAuth?> GetByTelegramIdAsync(long telegramId);
        Task<IEnumerable<TelegramAuth>> GetAllAsync();
        Task<TelegramAuth> CreateAsync(TelegramAuth telegramAuth);
        Task<TelegramAuth> UpdateAsync(TelegramAuth telegramAuth);
        Task DeleteAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
    }
}