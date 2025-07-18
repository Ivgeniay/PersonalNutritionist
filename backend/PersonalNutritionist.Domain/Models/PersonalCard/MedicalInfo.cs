namespace PersonalNutritionist.Domain.Models.PersonalCard
{
    public class MedicalInfo
    {
        public Guid Id { get; set; }
        public Guid PersonCardId { get; set; }
        public string ChronicDiseases { get; set; } = string.Empty;
        public string Allergies { get; set; } = string.Empty;
        public string Medications { get; set; } = string.Empty;
        public string HormonalStatus { get; set; } = string.Empty;
        public string DigestiveSystemStatus { get; set; } = string.Empty;
        public string BloodTestResults { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        
        public PersonCard? PersonCard { get; set; }
    }
}