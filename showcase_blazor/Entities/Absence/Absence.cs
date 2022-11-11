using showcase_blazor.Entities.Lifecycle;
using showcase_blazor.Interfaces;
using showcase_blazor.Pages;
using System.Security.Cryptography.X509Certificates;

namespace showcase_blazor.Entities
{
    public class Absence: IState, IRules
    {
        public Absence()
        {
            
        }

        public Enum? State { get; set; }
        //public File File { get; set; }
        public State? ObjectState { get; set; }
        public Enum Stages { get; set; }
        //public Manager(Type lifecycleObjectType)
        //{
        //    Stages = State.Stages.Initial;
        //}
        public static IState GetState() => new State(typeof(Absence));

        public static IRules GetRules() => new Rules();

    }



}
