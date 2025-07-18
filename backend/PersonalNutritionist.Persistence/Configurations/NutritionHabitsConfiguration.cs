using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalNutritionist.Domain.Models.PersonalCard;
using Microsoft.EntityFrameworkCore;
using PersonalNutritionist.Domain.Const;

namespace PersonalNutritionist.Persistence.Configurations
{
    public class NutritionHabitsConfiguration : IEntityTypeConfiguration<NutritionHabits>
    {
        public void Configure(EntityTypeBuilder<NutritionHabits> builder)
        {
            builder.ToTable("NutritionHabits");

            builder.HasKey(nh => nh.Id);

            builder.Property(nh => nh.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(nh => nh.PersonCardId)
                .IsRequired();

            builder.Property(nh => nh.CurrentDiet)
                .HasMaxLength(Consts.Validation.CURRENT_DIET_MAX_LENGTH);

            builder.Property(nh => nh.FoodPreferences)
                .HasMaxLength(Consts.Validation.FOOD_PREFERENCES_MAX_LENGTH);

            builder.Property(nh => nh.MealPattern)
                .IsRequired();

            builder.Property(nh => nh.AlcoholConsumption)
                .IsRequired();

            builder.Property(nh => nh.DailyWaterIntake)
                .IsRequired()
                .HasPrecision(5, 2);

            builder.Property(nh => nh.SupplementsAndVitamins)
                .HasMaxLength(Consts.Validation.SUPPLEMENTS_AND_VITAMINS_MAX_LENGTH);

            builder.Property(nh => nh.CreatedAt)
                .IsRequired();

            builder.Property(nh => nh.UpdatedAt)
                .IsRequired();

            builder.HasOne(nh => nh.PersonCard)
                .WithOne(pc => pc.NutritionHabits)
                .HasForeignKey<NutritionHabits>(nh => nh.PersonCardId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}