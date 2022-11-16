using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Interfaces;

namespace Data
{
    public class Patient : IPatient
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        private Gender _gender = Gender.Unspecified;
        public Gender Gender { get { return _gender; } set { _gender = value; } }
    }
    public enum Gender
    {
        Unspecified = 0,
        Female = 1,
        Male = 2
    }
}
