namespace TutorialBlog.WebApi.Entities
{
    public enum BlogType
    {
        Tutorial,
        Blog
    }
    public class Blog : EntityBase<Blog>
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public User Author { get; set; }
        public BlogType BlogType { get; set; }
        public Blog PreviousBlog { get;set; }
        public Blog NextBlog { get;set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public int Views { get; set; }
        public int Votes { get; set; }
        public string shortUrl { get; set; }

    }
}
