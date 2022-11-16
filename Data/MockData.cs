using Data.Interfaces;

namespace Data
{
    public class MockData
    {
        private ParacetamolTablets _paracetamolTablets = new ParacetamolTablets();
        private ParacetamolSachets _paracetamolSachets = new ParacetamolSachets();
        private Hoestdrank _hoestdrank = new Hoestdrank();
        private Oogdruppels _oogdruppels = new Oogdruppels();

        public ParacetamolTablets ParacetamolTablets_mock { get { return _paracetamolTablets; } set { _paracetamolTablets = value; } }
        public ParacetamolSachets ParacetamolSachets_mock { get { return _paracetamolSachets; } set { _paracetamolSachets = value; } }
        public Hoestdrank Hoestdrank_mock { get { return _hoestdrank; } set { _hoestdrank = value; } }
        public Oogdruppels Oogdruppels_mock { get { return _oogdruppels; } set { _oogdruppels = value; } }

        public MockData()
        {
            ParacetamolTablets_mock = new ParacetamolTablets();
            ParacetamolSachets_mock = new ParacetamolSachets();
            Hoestdrank_mock = new Hoestdrank();
            Oogdruppels_mock = new Oogdruppels();
        }

        public MockData(FunContext context)
        {
            ParacetamolTablets_mock = new ParacetamolTablets();
            ParacetamolSachets_mock = new ParacetamolSachets();
            Hoestdrank_mock = new Hoestdrank();
            Oogdruppels_mock = new Oogdruppels();

            context.AddRange(ParacetamolTablets_mock, ParacetamolSachets_mock, Hoestdrank_mock, Oogdruppels_mock);
            context.SaveChanges();
        }

        public class ParacetamolTablets : Medicine
        {
            public ParacetamolTablets()
            {
                Name = "Paracetamol 500/mg";
                Packaging.Name = "Doos met 2 strips";
                Packaging.PackagingUnit.Name = "Strip";
                Packaging.PackagingUnit.UnitKind = UnitKind.Strip;
                Packaging.NumberOfPackagingUnits = 2;
                Unit = IMedicine.MedicineUnitEnum.Tablets;
                MedicineUnitValue = 10;
            }
        }

        public class ParacetamolSachets : Medicine
        {
            public ParacetamolSachets()
            {
                Name = "Paracetamol 500/mg";
                Packaging.Name = "Doos met 20 sachets";
                Packaging.PackagingUnit.Name = "Sachets";
                Packaging.PackagingUnit.UnitKind = UnitKind.Sachets;
                Packaging.NumberOfPackagingUnits = 20;
                Unit = IMedicine.MedicineUnitEnum.Milligrams;
                MedicineUnitValue = 2;
            }
        }

        public class Hoestdrank : Medicine
        {
            public Hoestdrank()
            {
                Name = "Hoestdrank broomhexine hcl 4mg / 5ml";
                Packaging.Name = "Fles met lepel";
                Packaging.PackagingUnit.Name = "Fles";
                Packaging.PackagingUnit.UnitKind = UnitKind.Bottle;
                Packaging.NumberOfPackagingUnits = 1;
                Unit = IMedicine.MedicineUnitEnum.Milliliters;
                MedicineUnitValue = 150;
            }
        }

        public class Oogdruppels : Medicine
        {
            public Oogdruppels()
            {
                Name = "Oogdruppels";
                Packaging.Name = "Fles met pipet";
                Packaging.PackagingUnit.Name = "Flesje";
                Packaging.PackagingUnit.UnitKind = UnitKind.Bottle;
                Packaging.NumberOfPackagingUnits = 1;
                Unit = IMedicine.MedicineUnitEnum.Milliliters;
                MedicineUnitValue = 25;
            }
        }
    }

}
