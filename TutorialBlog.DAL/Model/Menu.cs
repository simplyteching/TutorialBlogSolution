using System;
using System.Collections.Generic;

namespace TutorialBlog.DAL.Model
{
    public partial class Menu
    {
        public int MenuId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string Url { get; set; } = null!;
        public string MenuType { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public string CreatedAt { get; set; } = null!;
        public string? UpdatedBy { get; set; }
        public string? UpdatedAt { get; set; }
    }
}
