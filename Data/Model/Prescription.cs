using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Interfaces;

namespace Data
{
    public class Prescription : IPrescription
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string PatientId { get; set; }
        public DateTime? Prescribed { get; set; }

        public string? PeriodOfUse { get; set; }
        public string? InstructionsForUse { get; set; }

        private DeliveryMethod _deliveryMethod = DeliveryMethod.Undefined;
        public DeliveryMethod DeliveryMethod { get { return _deliveryMethod; } set { _deliveryMethod = value; } }

    }

    public enum DeliveryMethod
    {
        Undefined = 0,
        TakeAway = 1,
        HomeDelivery = 2
    }
}
