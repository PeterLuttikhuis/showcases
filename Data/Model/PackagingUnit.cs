using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data
{
    public class PackagingUnit : IPackagingUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private UnitKind _unitKind = UnitKind.Undefined;
        public UnitKind UnitKind { get { return _unitKind; } set { _unitKind = value; } }

    }
    public enum UnitKind
    {
        Undefined = 0,
        Bottle = 1,
        Strip = 2,
        Sachets = 3,
        Other = 4
    }

}
