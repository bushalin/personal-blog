namespace ApplicationCore.Entities.PostAggregate
{
    public class PostDetail : BaseEntity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public PostDetail(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void UpdatePostName(string name)
        {
            Name = name;
        }

        public void UpdatePostDescription(string description)
        {
            Description = description;
        }
    }
}