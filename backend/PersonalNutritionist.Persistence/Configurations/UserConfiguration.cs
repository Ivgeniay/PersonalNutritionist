using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalNutritionist.Domain.Models.Auth;
using PersonalNutritionist.Domain.Models.Entities;

namespace PersonalNutritionist.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(u => u.CreatedAt)
                .IsRequired();

            builder.Property(u => u.UpdatedAt)
                .IsRequired();

            builder.Property(u => u.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            builder.HasMany(u => u.People)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(u => u.LoginPasswordAuths)
                .WithOne(l => l.User)
                .HasForeignKey<LoginPasswordAuth>(l => l.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(u => u.TelegramAuths)
                .WithOne(t => t.User)
                .HasForeignKey<TelegramAuth>(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}