namespace TutorialBlog.WebApi.Entities
{
    public class User : EntityBase<User>
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Details { get;set; }
        public string ProfilePicture { get; set; }
        public string websiteLink { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int IsActive { get; set; }

    }
}
