using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalNutritionist.Domain.Const;
using PersonalNutritionist.Domain.Models.Auth;

namespace PersonalNutritionist.Persistence.Configurations
{
    public class TelegramAuthConfiguration : IEntityTypeConfiguration<TelegramAuth>
    {
        public void Configure(EntityTypeBuilder<TelegramAuth> builder)
        {
            builder.ToTable("TelegramAuths");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(t => t.UserId)
                .IsRequired();

            builder.Property(t => t.TelegramId)
                .IsRequired();

            builder.Property(t => t.TelegramUsername)
                .HasMaxLength(Consts.Validation.TELEGRAM_STRING_LENGTH);

            builder.Property(t => t.FirstName)
                .HasMaxLength(Consts.Validation.TELEGRAM_STRING_LENGTH);

            builder.Property(t => t.LastName)
                .HasMaxLength(Consts.Validation.TELEGRAM_STRING_LENGTH);

            builder.Property(t => t.CreatedAt)
                .IsRequired();

            builder.Property(t => t.UpdatedAt)
                .IsRequired();

            builder.Property(t => t.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            builder.HasOne(t => t.User)
                .WithOne(u => u.TelegramAuth)
                .HasForeignKey<TelegramAuth>(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}