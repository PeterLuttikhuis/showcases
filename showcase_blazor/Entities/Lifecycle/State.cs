using showcase_blazor.Interfaces;
using showcase_blazor.Helpers;
using System.Collections.Generic;

namespace showcase_blazor.Entities.Lifecycle
{
    public class State: IState
    {
        public State() { }


        public List<string, Type, object> KeyTypeValues { get; set; }
        public object? StartingValue { get; set; }
        public object? EndingValue { get; set; }
        public List<object>? Events { get; set; }

        public class List<T1, T2, T3>
        {
        }
        public enum Stages 
        {
            Initial = 0,
            Begin = 1,
            Intermediate = 2,
            Ending = 3,
            Completed = 4
        }
    }
}
