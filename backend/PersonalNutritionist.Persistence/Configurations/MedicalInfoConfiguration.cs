using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalNutritionist.Domain.Models.PersonalCard;
using Microsoft.EntityFrameworkCore;
using PersonalNutritionist.Domain.Const;

namespace PersonalNutritionist.Persistence.Configurations
{
    public class MedicalInfoConfiguration : IEntityTypeConfiguration<MedicalInfo>
    {
        public void Configure(EntityTypeBuilder<MedicalInfo> builder)
        {
            builder.ToTable("MedicalInfos");

            builder.HasKey(mi => mi.Id);

            builder.Property(mi => mi.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(mi => mi.PersonCardId)
                .IsRequired();

            builder.Property(mi => mi.ChronicDiseases)
                .HasMaxLength(Consts.Validation.CHRONIC_DISEASES_MAX_LENGTH);

            builder.Property(mi => mi.Allergies)
                .HasMaxLength(Consts.Validation.ALLERGIES_MAX_LENGTH);

            builder.Property(mi => mi.Medications)
                .HasMaxLength(Consts.Validation.MEDICATIONS_MAX_LENGTH);

            builder.Property(mi => mi.HormonalStatus)
                .HasMaxLength(Consts.Validation.HORMONAL_STATUS_MAX_LENGTH);

            builder.Property(mi => mi.DigestiveSystemStatus)
                .HasMaxLength(Consts.Validation.DIGESTIVE_SYSTEM_STATUS_MAX_LENGTH);

            builder.Property(mi => mi.BloodTestResults)
                .HasMaxLength(Consts.Validation.BLOOD_TEST_RESULTS_MAX_LENGTH);

            builder.Property(mi => mi.CreatedAt)
                .IsRequired();

            builder.Property(mi => mi.UpdatedAt)
                .IsRequired();

            builder.HasOne(mi => mi.PersonCard)
                .WithOne(pc => pc.MedicalInfo)
                .HasForeignKey<MedicalInfo>(mi => mi.PersonCardId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}