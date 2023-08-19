namespace TutorialBlog.WebApi.Entities
{
    public abstract class EntityBase<T>
    {
        public User CreatedBy { get; set; }
        public User UpdatedBy { get; set; }
        public DateTime  CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set;}

    }
}
