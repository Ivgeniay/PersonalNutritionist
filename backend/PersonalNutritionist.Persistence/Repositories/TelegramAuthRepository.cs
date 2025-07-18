using Microsoft.EntityFrameworkCore;
using PersonalNutritionist.Domain.Interfaces.Repositories;
using PersonalNutritionist.Domain.Models.Auth;

namespace PersonalNutritionist.Persistence.Repositories
{
    public class TelegramAuthRepository : ITelegramAuthRepository
    {
        private readonly ApplicationDbContext _context;

        public TelegramAuthRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TelegramAuth?> GetByIdAsync(Guid id)
        {
            return await _context.TelegramAuths.FindAsync(id);
        }

        public async Task<TelegramAuth?> GetByUserIdAsync(Guid userId)
        {
            return await _context.TelegramAuths.FirstOrDefaultAsync(t => t.UserId == userId);
        }

        public async Task<TelegramAuth?> GetByTelegramIdAsync(long telegramId)
        {
            return await _context.TelegramAuths.FirstOrDefaultAsync(t => t.TelegramId == telegramId);
        }

        public async Task<IEnumerable<TelegramAuth>> GetAllAsync()
        {
            return await _context.TelegramAuths.ToListAsync();
        }

        public async Task<TelegramAuth> CreateAsync(TelegramAuth telegramAuth)
        {
            _context.TelegramAuths.Add(telegramAuth);
            return telegramAuth;
        }

        public async Task<TelegramAuth> UpdateAsync(TelegramAuth telegramAuth)
        {
            _context.TelegramAuths.Update(telegramAuth);
            return telegramAuth;
        }

        public async Task DeleteAsync(Guid id)
        {
            var telegramAuth = await _context.TelegramAuths.FindAsync(id);
            if (telegramAuth != null)
            {
                _context.TelegramAuths.Remove(telegramAuth);
            }
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.TelegramAuths.AnyAsync(t => t.Id == id);
        }
    }
}