namespace showcase_blazor.Entities
{
    public class Activity
    {
        public string Name { get; set; }

        public Activity(string name, bool isRequired, int order, string? description)
        {
            Name = name;
            IsRequired = isRequired;
            Order = order;
            Description = description;
        }

        public string? Description { get; set; }
        public bool IsRequired { get; set; }
        public int Order { get; set; }
    }
}
