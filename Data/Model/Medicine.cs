using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private Packaging _packaging = new Packaging();

        public Packaging Packaging
        { get { return _packaging; } set { _packaging = value; } }

        private MedicineUnit _medicineUnit = MedicineUnit.Undefined;
        public MedicineUnit MedicineUnit { get {return _medicineUnit; } set {_medicineUnit = value; } }

        public int? MedicineUnitValue { get; set; }
    }

    public enum MedicineUnit
    {
        Undefined = 0,
        Tablets = 1,
        Milliliters = 2,
        Milligrams = 3
    }
}