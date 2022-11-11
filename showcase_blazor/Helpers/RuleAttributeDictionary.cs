namespace showcase_blazor.Helpers
{
    public struct RuleAttributes
    {
        public Type Type;
        public object Value;
    }

    public class RuleAttributeDictionary : Dictionary<string, RuleAttributes>
    {
        public void Add(string attributeName, Type attributeType, object attributeValue)
        {
            RuleAttributes field;
            field.Type = attributeType;
            field.Value = attributeValue;
            this.Add(attributeName, field);
        }
    }

    //var dict = new AttributeDictionary();
    //dict.Add(StartValue, System.Int32, 0);
}
