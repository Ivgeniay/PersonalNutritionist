using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalNutritionist.Domain.Models.PersonalCard;

namespace PersonalNutritionist.Persistence.Configurations
{
    public class PhysicalParametersConfiguration : IEntityTypeConfiguration<PhysicalParameters>
    {
        public void Configure(EntityTypeBuilder<PhysicalParameters> builder)
        {
            builder.ToTable("PhysicalParameters");

            builder.HasKey(ph => ph.Id);

            builder.Property(ph => ph.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(ph => ph.PersonCardId)
                .IsRequired();

            builder.Property(ph => ph.Height)
                .IsRequired();

            builder.Property(ph => ph.CurrentWeight)
                .IsRequired()
                .HasPrecision(5, 2);

            builder.Property(ph => ph.BodyFatPercentage)
                .HasPrecision(5, 2);

            builder.Property(ph => ph.BodyType)
                .IsRequired();

            builder.Property(ph => ph.DesiredWeight)
                .HasPrecision(5, 2);

            builder.Property(ph => ph.CreatedAt)
                .IsRequired();

            builder.Property(ph => ph.UpdatedAt)
                .IsRequired();


            builder.HasOne(ph => ph.PersonCard)
                .WithOne(pc => pc.PhysicalParameters)
                .HasForeignKey<PhysicalParameters>(p => p.PersonCardId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}