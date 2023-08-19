using System;
using System.Collections.Generic;

namespace TutorialBlog.DAL.Model
{
    public partial class Activity
    {
        public int ActivityId { get; set; }
        public short Action { get; set; }
        public string Object { get; set; } = null!;
        public int UserId { get; set; }
        public string? Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
