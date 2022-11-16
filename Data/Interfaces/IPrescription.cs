namespace Data.Interfaces
{
    public interface IPrescription
    {
        DeliveryMethod DeliveryMethod { get; set; }
        int Id { get; set; }
        string? InstructionsForUse { get; set; }
        string Name { get; set; }
        string PatientId { get; set; }
        string? PeriodOfUse { get; set; }
        DateTime? Prescribed { get; set; }
    }
}