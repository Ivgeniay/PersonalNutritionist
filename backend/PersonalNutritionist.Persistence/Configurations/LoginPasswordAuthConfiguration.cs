using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalNutritionist.Domain.Const;
using PersonalNutritionist.Domain.Models.Auth;

namespace PersonalNutritionist.Persistence.Configurations
{
    public class LoginPasswordAuthConfiguration : IEntityTypeConfiguration<LoginPasswordAuth>
    {
        public void Configure(EntityTypeBuilder<LoginPasswordAuth> builder)
        {
            builder.ToTable("LoginPasswordAuths");

            builder.HasKey(l => l.Id);

            builder.Property(l => l.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(l => l.UserId)
                .IsRequired();

            builder.Property(l => l.Email)
                .IsRequired()
                .HasMaxLength(Consts.Validation.EMAIL_MAX_LENGTH);

            builder.Property(l => l.PasswordHash)
                .IsRequired()
                .HasMaxLength(Consts.Validation.PASSWORD_HASH_MAX_LENGTH);

            builder.Property(l => l.CreatedAt)
                .IsRequired();

            builder.Property(l => l.UpdatedAt)
                .IsRequired();

            builder.Property(l => l.IsActive)
                .IsRequired();

            builder.HasOne(l => l.User)
                .WithOne(u => u.LoginPasswordAuth)
                .HasForeignKey<LoginPasswordAuth>(l => l.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}