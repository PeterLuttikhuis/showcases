using Data.Interfaces;
using static Data.Interfaces.IMedicine;

namespace Data
{
    public class Medicine : IMedicine
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private Packaging _packaging = new Packaging();

        public Packaging Packaging
        { get { return _packaging; } set { _packaging = value; } }

        private MedicineUnitEnum _medicineUnit = MedicineUnitEnum.Undefined;
        public MedicineUnitEnum Unit { get { return _medicineUnit; } set { _medicineUnit = value; } }

        public int? MedicineUnitValue { get; set; }
    }


}