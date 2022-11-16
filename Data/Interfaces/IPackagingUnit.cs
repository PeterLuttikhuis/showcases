namespace Data.Interfaces
{
    public interface IPackagingUnit
    {
        int Id { get; set; }
        string Name { get; set; }
        UnitKind UnitKind { get; set; }
    }
}