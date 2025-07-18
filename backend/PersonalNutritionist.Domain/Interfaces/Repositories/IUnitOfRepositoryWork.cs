namespace PersonalNutritionist.Domain.Interfaces.Repositories
{
    public interface IUnionOfRepositoryWork : IDisposable
    {
        IUserRepository Users { get; }
        IPersonCardRepository PersonCards { get; }
        IPhysicalParametersRepository PhysicalParameters { get; }
        IGoalsRepository Goals { get; }
        IActivityInfoRepository ActivityInfos { get; }
        IMedicalInfoRepository MedicalInfos { get; }
        INutritionHabitsRepository NutritionHabits { get; }
        ILifestyleRepository Lifestyles { get; }
        ILoginPasswordAuthRepository LoginPasswordAuths { get; }
        ITelegramAuthRepository TelegramAuths { get; }
        
        Task<int> SaveChangesAsync();
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
    }
}