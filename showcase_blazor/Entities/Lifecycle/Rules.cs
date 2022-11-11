using Microsoft.AspNetCore.DataProtection.KeyManagement;
using showcase_blazor.Helpers;
using showcase_blazor.Interfaces;

namespace showcase_blazor.Entities.Lifecycle
{
    public class Rules: IRules
    {
        public object BeginValue { get; set; }
        public object EndValue { get; set; }

        public RuleAttributeDictionary ruleDictionary { get; set; }

        public Rules GetStateDictionary(Type lifecycleObjectType)
        {
            var dict = ruleDictionary ?? new RuleAttributeDictionary();

            // todo: get attribute-name, type and value from DB?

            switch (lifecycleObjectType)
            {
                case typeof(Absence):
                    dict.Add("BeginValue", typeof(int), 0);
                    break;
                default:
                    throw new NotImplementedException();
            }
            return state;
        }

    }
}
