using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalNutritionist.Domain.Const;
using PersonalNutritionist.Domain.Models.PersonalCard;

namespace PersonalNutritionist.Persistence.Configurations
{
    public class LifestyleConfiguration : IEntityTypeConfiguration<Lifestyle>
    {
        public void Configure(EntityTypeBuilder<Lifestyle> builder)
        {
            builder.ToTable("Lifestyles");

            builder.HasKey(ls => ls.Id);

            builder.Property(ls => ls.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(ls => ls.PersonCardId)
                .IsRequired();

            builder.Property(ls => ls.SleepHours)
                .IsRequired();

            builder.Property(ls => ls.StressLevel)
                .IsRequired();

            builder.Property(ls => ls.SocialFactors)
                .HasMaxLength(Consts.Validation.SOCIAL_FACTORS_MAX_LENGTH);

            builder.Property(ls => ls.FoodBudget)
                .IsRequired()
                .HasPrecision(5, 2);

            builder.Property(ls => ls.CookingTimeAvailable)
                .IsRequired();

            builder.Property(ls => ls.CookingSkills)
                .IsRequired();

            builder.Property(ls => ls.PreviousDietExperience)
                .HasMaxLength(Consts.Validation.PREVIOUS_DIETS_EXPERIENCE_MAX_LENGTH);

            builder.Property(ls => ls.PsychologicalRelationshipWithFood)
                .HasMaxLength(Consts.Validation.PSYCHOLOGICAL_RELATIONSHIP_WITH_FOOD_MAX_LENGTH);


            builder.Property(ls => ls.MotivationLevel)
                .IsRequired();

            builder.Property(ls => ls.CreatedAt)
                .IsRequired();

            builder.Property(ls => ls.UpdatedAt)
                .IsRequired();

            builder.HasOne(ls => ls.PersonCard)
                .WithOne(pc => pc.Lifestyle)
                .HasForeignKey<Lifestyle>(ls => ls.PersonCardId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}