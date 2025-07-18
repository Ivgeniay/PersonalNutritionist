using Microsoft.EntityFrameworkCore;
using PersonalNutritionist.Domain.Interfaces.Repositories;
using PersonalNutritionist.Domain.Models.PersonalCard;



namespace PersonalNutritionist.Persistence.Repositories
{
    public class ActivityInfoRepository : IActivityInfoRepository
    {
        private readonly ApplicationDbContext _context;

        public ActivityInfoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ActivityInfo?> GetByIdAsync(Guid id)
        {
            return await _context.ActivityInfos.FindAsync(id);
        }

        public async Task<ActivityInfo?> GetByPersonCardIdAsync(Guid personCardId)
        {
            return await _context.ActivityInfos.FirstOrDefaultAsync(a => a.PersonCardId == personCardId);
        }

        public async Task<IEnumerable<ActivityInfo>> GetAllAsync()
        {
            return await _context.ActivityInfos.ToListAsync();
        }

        public async Task<ActivityInfo> CreateAsync(ActivityInfo activityInfo)
        {
            _context.ActivityInfos.Add(activityInfo);
            return activityInfo;
        }

        public async Task<ActivityInfo> UpdateAsync(ActivityInfo activityInfo)
        {
            _context.ActivityInfos.Update(activityInfo);
            return activityInfo;
        }

        public async Task DeleteAsync(Guid id)
        {
            var activityInfo = await _context.ActivityInfos.FindAsync(id);
            if (activityInfo != null)
            {
                _context.ActivityInfos.Remove(activityInfo);
            }
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.ActivityInfos.AnyAsync(a => a.Id == id);
        }
    }
}
