using PersonalNutritionist.Domain.Models.Auth;

namespace PersonalNutritionist.Domain.Interfaces.Repositories
{
    public interface ILoginPasswordAuthRepository
    {
        Task<LoginPasswordAuth?> GetByIdAsync(Guid id);
        Task<LoginPasswordAuth?> GetByUserIdAsync(Guid userId);
        Task<LoginPasswordAuth?> GetByEmailAsync(string email);
        Task<IEnumerable<LoginPasswordAuth>> GetAllAsync();
        Task<LoginPasswordAuth> CreateAsync(LoginPasswordAuth loginPasswordAuth);
        Task<LoginPasswordAuth> UpdateAsync(LoginPasswordAuth loginPasswordAuth);
        Task DeleteAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
    }
}
