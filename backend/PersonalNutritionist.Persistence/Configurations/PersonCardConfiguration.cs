using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalNutritionist.Domain.Const;
using PersonalNutritionist.Domain.Models.PersonalCard;

namespace PersonalNutritionist.Persistence.Configurations
{
    public class PersonCardConfiguration : IEntityTypeConfiguration<PersonCard>
    {
        public void Configure(EntityTypeBuilder<PersonCard> builder)
        {
            builder.ToTable("PersonCards");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(p => p.UserId)
                .IsRequired();

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(Consts.Validation.NAME_MAX_LENGTH);

            builder.Property(p => p.Age)
                .IsRequired();

            builder.Property(p => p.CreatedAt)
                .IsRequired();

            builder.Property(p => p.UpdatedAt)
                .IsRequired();

            builder.Property(p => p.IsActive)
                .IsRequired();

            builder.Property(p => p.Gender)
                .IsRequired();

            builder.HasOne(p => p.PhysicalParameters)
                .WithOne(ph => ph.PersonCard)
                .HasForeignKey<PhysicalParameters>(ph => ph.PersonCardId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Goals)
                .WithOne(g => g.PersonCard)
                .HasForeignKey<Goals>(g => g.PersonCardId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.ActivityInfo)
                .WithOne(ai => ai.PersonCard)
                .HasForeignKey<ActivityInfo>(ai => ai.PersonCardId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.MedicalInfo)
                .WithOne(m => m.PersonCard)
                .HasForeignKey<MedicalInfo>(m => m.PersonCardId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.NutritionHabits)
                .WithOne(nh => nh.PersonCard)
                .HasForeignKey<NutritionHabits>(nh => nh.PersonCardId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Lifestyle)
                .WithOne(ls => ls.PersonCard)
                .HasForeignKey<Lifestyle>(ls => ls.PersonCardId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.User)
                .WithMany(u => u.People)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}