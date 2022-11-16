using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Packaging
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int PackagingUnitId { get; set; }

        private PackagingUnit _packagingUnit = new PackagingUnit();
        public PackagingUnit PackagingUnit
        { get { return _packagingUnit; } set { _packagingUnit = value; } }

        private int _numberOfPackagingUnits = 0;
        public int NumberOfPackagingUnits
        {
            get { return _numberOfPackagingUnits; }
            set { _numberOfPackagingUnits = value; }
        }
    }
}
