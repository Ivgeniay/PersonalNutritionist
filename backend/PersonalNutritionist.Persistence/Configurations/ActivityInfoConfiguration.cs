using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalNutritionist.Domain.Models.PersonalCard;

namespace PersonalNutritionist.Persistence.Configurations
{
    public class ActivityInfoConfiguration : IEntityTypeConfiguration<ActivityInfo>
    {
        public void Configure(EntityTypeBuilder<ActivityInfo> builder)
        {
            builder.ToTable("ActivityInfos");

            builder.HasKey(ai => ai.Id);

            builder.Property(ai => ai.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(ai => ai.PersonCardId)
                .IsRequired();

            builder.Property(ai => ai.ProfessionalActivity)
                .IsRequired();

            builder.Property(ai => ai.WorkoutFrequency)
                .IsRequired();

            builder.Property(ai => ai.WorkoutIntensity)
                .IsRequired();

            builder.Property(ai => ai.PhysicalActivityType)
                .IsRequired();

            builder.Property(ai => ai.DailyActivityLevel)
                .IsRequired();

            builder.Property(ai => ai.CreatedAt)
                .IsRequired();

            builder.Property(ai => ai.UpdatedAt)
                .IsRequired();

            builder.HasOne(ai => ai.PersonCard)
                .WithOne(pc => pc.ActivityInfo)
                .HasForeignKey<ActivityInfo>(ai => ai.PersonCardId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}