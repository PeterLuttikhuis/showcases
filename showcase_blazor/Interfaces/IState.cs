using Microsoft.AspNetCore.DataProtection.KeyManagement;
using showcase_blazor.Entities.Lifecycle;
using showcase_blazor.Helpers;
using System.Collections.Generic;

namespace showcase_blazor.Interfaces
{
    public interface IState
    {
        public object? StartingValue { get; set; }
        public object? EndingValue { get; set; }
        public List<object>?  Events { get; set; }
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
