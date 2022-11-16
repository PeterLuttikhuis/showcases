namespace Data.Interfaces
{
    public interface IPackaging
    {
        int Id { get; set; }
        string Name { get; set; }
        int NumberOfPackagingUnits { get; set; }
        PackagingUnit PackagingUnit { get; set; }
    }
}