using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalNutritionist.Domain.Const;
using PersonalNutritionist.Domain.Models.Enums;
using PersonalNutritionist.Domain.Models.PersonalCard;

namespace PersonalNutritionist.Persistence.Configurations
{
    public class GoalsConfiguration : IEntityTypeConfiguration<Goals>
    {
        public void Configure(EntityTypeBuilder<Goals> builder)
        {
            builder.ToTable("Goals");

            builder.HasKey(g => g.Id);

            builder.Property(g => g.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(g => g.PersonCardId)
                .IsRequired();

            builder.Property(g => g.DesiredWeight)
                .HasPrecision(5, 2);

            builder.Property(g => g.DesiredBodyChanges)
                .HasMaxLength(Consts.Validation.DESIRE_BODY_CHANGES_MAX_LENGTH);

            builder.Property(g => g.TargetDate);

            builder.Property(g => g.Priority)
                .IsRequired();

            builder.Property(g => g.CreatedAt)
                .IsRequired();

            builder.Property(g => g.UpdatedAt)
                .IsRequired();

            builder.HasOne(g => g.PersonCard)
                .WithOne(pc => pc.Goals)
                .HasForeignKey<Goals>(g => g.PersonCardId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}