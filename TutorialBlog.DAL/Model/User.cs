using System;
using System.Collections.Generic;

namespace TutorialBlog.DAL.Model
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
        public string? Details { get; set; }
        public string? ProfilePicture { get; set; }
        public string? WebsiteLink { get; set; }
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public byte IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
