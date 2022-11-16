namespace showcase_blazor.Data.Models
{
    public class PackagingUnit
    {
        public PackagingUnit() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfUnitsPerPackaging {  get; set; }
        public Unit Unit { get; set; }
    }

    public enum Unit
    {
        None = 0,
        Sachets = 1,
        Strip = 2,
        Bottle = 3,
        Unknown = 4
    }
}
