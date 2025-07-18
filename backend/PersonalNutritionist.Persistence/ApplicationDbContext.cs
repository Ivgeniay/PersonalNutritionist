using PersonalNutritionist.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using PersonalNutritionist.Domain.Models.Auth;
using PersonalNutritionist.Domain.Models.PersonalCard;

namespace PersonalNutritionist.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<PersonCard> PersonCards { get; set; }
        public DbSet<ActivityInfo> ActivityInfos { get; set; }
        public DbSet<Goals> Goals { get; set; }
        public DbSet<Lifestyle> Lifestyles { get; set; }
        public DbSet<MedicalInfo> MedicalInfos { get; set; }
        public DbSet<NutritionHabits> NutritionHabits { get; set; }
        public DbSet<PhysicalParameters> PhysicalParameters { get; set; }
        public DbSet<LoginPasswordAuth> LoginPasswordAuths { get; set; }
        public DbSet<TelegramAuth> TelegramAuths { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}