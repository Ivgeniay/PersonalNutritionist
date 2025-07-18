using Microsoft.EntityFrameworkCore;
using PersonalNutritionist.Domain.Interfaces.Repositories;
using PersonalNutritionist.Domain.Models.Auth;

namespace PersonalNutritionist.Persistence.Repositories
{
    public class LoginPasswordAuthRepository : ILoginPasswordAuthRepository
    {
        private readonly ApplicationDbContext _context;

        public LoginPasswordAuthRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<LoginPasswordAuth?> GetByIdAsync(Guid id)
        {
            return await _context.LoginPasswordAuths.FindAsync(id);
        }

        public async Task<LoginPasswordAuth?> GetByUserIdAsync(Guid userId)
        {
            return await _context.LoginPasswordAuths.FirstOrDefaultAsync(l => l.UserId == userId);
        }

        public async Task<LoginPasswordAuth?> GetByEmailAsync(string email)
        {
            return await _context.LoginPasswordAuths.FirstOrDefaultAsync(l => l.Email == email);
        }

        public async Task<IEnumerable<LoginPasswordAuth>> GetAllAsync()
        {
            return await _context.LoginPasswordAuths.ToListAsync();
        }

        public async Task<LoginPasswordAuth> CreateAsync(LoginPasswordAuth loginPasswordAuth)
        {
            _context.LoginPasswordAuths.Add(loginPasswordAuth);
            return loginPasswordAuth;
        }

        public async Task<LoginPasswordAuth> UpdateAsync(LoginPasswordAuth loginPasswordAuth)
        {
            _context.LoginPasswordAuths.Update(loginPasswordAuth);
            return loginPasswordAuth;
        }

        public async Task DeleteAsync(Guid id)
        {
            var loginPasswordAuth = await _context.LoginPasswordAuths.FindAsync(id);
            if (loginPasswordAuth != null)
            {
                _context.LoginPasswordAuths.Remove(loginPasswordAuth);
            }
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.LoginPasswordAuths.AnyAsync(l => l.Id == id);
        }
    }
}
