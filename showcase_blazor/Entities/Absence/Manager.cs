using showcase_blazor.Entities.Lifecycle;
using showcase_blazor.Interfaces;

namespace showcase_blazor.Entities.Absence
{
    public class Manager : ILifecycle
    {
        public State? ObjectState { get; set; }
        public Enum Stages { get; set; }
        public Manager(Type lifecycleObjectType)
        {
            Stages = State.Stages.Initial;
        }
        public static IState GetState() => new State();

        public static IRules GetRules() => new Rules();
    }
}
