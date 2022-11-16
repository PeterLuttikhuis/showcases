namespace showcase_blazor.Data.Models
{
    public class Packaging
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfMedicinePerPackaging { get; set; }

        public PackagingUnit PackagingUnit { get; set; }
        public Packaging() { }

    }
}
