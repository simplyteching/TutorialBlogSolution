using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialBlog.Entities.Entities
{
    public enum MenuType
    {
        Menu,
        SubMenu,
        Chapter
    }
    public class Menu
    {
        public int MenuId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public MenuType MenuType { get; set; }

    }
}
