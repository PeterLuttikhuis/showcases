namespace showcase_blazor.Entities
{
    public class File
    {
        public int Id { get; set; }
        public List<Activity>? Activities { get; set; }
        public File(int id, List<Activity> activities)
        {
            Id = id;
            Activities = activities;
        }
    }
}
