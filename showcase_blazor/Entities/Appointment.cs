using showcase_blazor.Interfaces.ILifecycle;

namespace showcase_blazor.Entities
{
    public class Base : IBase
    {
        public Base() { }
        Type Type { get; }
        Enum State { get; }
    }
}
