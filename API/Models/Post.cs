namespace API.Models
{
    public class Post
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Details { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid? UserId { get; set; }
    }
}
