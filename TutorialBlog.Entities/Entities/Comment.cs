namespace TutorialBlog.WebApi.Entities
{
    public class Comment:EntityBase<Comment>
    {
        public int CommentID { get; set; }
        public string Content { get; set; }
        public User Author { get; set; }
        public Blog Blog { get; set; }
        public string CommentText { get; set; }

    }
}
