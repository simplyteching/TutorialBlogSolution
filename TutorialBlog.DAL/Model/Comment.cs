using System;
using System.Collections.Generic;

namespace TutorialBlog.DAL.Model
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public string? Content { get; set; }
        public string? Author { get; set; }
        public string? Blog { get; set; }
    }
}
