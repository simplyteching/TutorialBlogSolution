namespace TutorialBlog.WebApi.Entities
{
    public class Activity:EntityBase<Activity>
    {
        public int ActivityID { get; set; }
        public string Action { get; set; }
        public User User { get; set; }
        public Blog Blog { get; set; }
        public Comment Comment { get; set; }

    }
}
