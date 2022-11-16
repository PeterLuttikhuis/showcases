using showcase_blazor.Data.Models;

namespace showcase_blazor.Helpers
{
    public class MockData
    {
        public List<Medicine> medicines = new List<Medicine>();
        public void Generate()
        {
            List<Medicine> list = new List<Medicine>();

            Medicine paracetamol = new Medicine();
            paracetamol.Id = 1;
            paracetamol.Name = "Paracetamol";

            paracetamol.packaging = new Packaging();
            paracetamol.packaging.PackagingUnit = new PackagingUnit(); ;
            paracetamol.packaging.Id = 1;
            paracetamol.packaging.PackagingUnit.Id= 1;
            paracetamol.packaging.PackagingUnit.Name = "Strips";
            paracetamol.packaging.PackagingUnit.NumberOfUnitsPerPackaging = 3;
            paracetamol.packaging.PackagingUnit.Unit = Unit.Strip;

            medicines.Add(paracetamol);
            
        }
    }
}
