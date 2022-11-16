using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ModuleForm
{
    public class Module
    {
        public Module() { }

        public List<Medicine> GetMedicines(FunContext context) {
            return context.Medicines.ToList();
        }

        public class Validation
        {
            public bool ValidatePackagingUnitKind(UnitKind unitKind, Medicine medicine) {
                bool result = false;
                switch (unitKind)
                {
                    case UnitKind.Strip:
                    case UnitKind.Bottle:
                        result = medicine.MedicineUnitValue.HasValue;
                        break;
                    default:
                        result = false;
                        break;
                }
                return result;
            }
        }
    }
        
    
}
