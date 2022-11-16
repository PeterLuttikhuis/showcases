namespace Data.Interfaces
{
    public interface IPatient
    {
        string Firstname { get; set; }
        Gender Gender { get; set; }
        int Id { get; set; }
        string Lastname { get; set; }
    }
}