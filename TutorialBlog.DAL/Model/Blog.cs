using System;
using System.Collections.Generic;

namespace TutorialBlog.DAL.Model
{
    public partial class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; } = null!;
        public string Title { get; set; } = null!;
        public int Author { get; set; }
        public int BlogType { get; set; }
        public int? PreviousBlogId { get; set; }
        public int? NextBlogId { get; set; }
        public string Content { get; set; } = null!;
        public string? Description { get; set; }
        public int Views { get; set; }
        public int Votes { get; set; }
        public string? ShortUrl { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
