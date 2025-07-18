using PersonalNutritionist.Domain.Models.Enums;

namespace PersonalNutritionist.Domain.Models.PersonalCard
{
    public class PhysicalParameters
    {
        public Guid Id { get; set; }
        public Guid PersonCardId { get; set; }
        public int Height { get; set; }
        public decimal CurrentWeight { get; set; }
        public decimal? BodyFatPercentage { get; set; }
        public BodyType BodyType { get; set; }
        public decimal? DesiredWeight { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        
        public PersonCard? PersonCard { get; set; }
    }
}