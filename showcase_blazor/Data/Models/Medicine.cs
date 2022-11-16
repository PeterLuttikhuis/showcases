using System.Reflection.Emit;

namespace showcase_blazor.Data.Models
{
    public class Medicine
    {
        public Medicine() { }

        public int Id { get; set; }
        public string Name { get; set; }
        public Packaging packaging { get; set; }
    }
}
