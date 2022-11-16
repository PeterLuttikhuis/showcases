namespace Data.Interfaces
{
    public interface IMedicine
    {
        MedicineUnitEnum Unit { get; set; }
        int? MedicineUnitValue { get; set; }
        string Name { get; set; }
        Packaging Packaging { get; set; }
        public enum MedicineUnitEnum
        {
            Undefined = 0,
            Tablets = 1,
            Milliliters = 2,
            Milligrams = 3
        }
    }
}