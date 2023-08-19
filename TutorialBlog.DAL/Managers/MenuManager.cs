using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialBlog.DAL.Interfaces;
using TutorialBlog.DAL.Model;

namespace TutorialBlog.DAL.Managers
{
    public class MenuManager : IMenuManager
    {
        private TutorialBlogContext _context;
        public MenuManager(TutorialBlogContext context)
        {
            _context = context;
        }
        public Menu CreateMenu(Menu menu)
        {
            throw new NotImplementedException();
        }

        public int DeleteMenu(int id)
        {
            throw new NotImplementedException();
        }

        public Menu GetMenu(int id)
        {
            throw new NotImplementedException();
        }

        public List<Menu> GetMenus(int forPageNumber = 0, int perPage = 20)
        {
            throw new NotImplementedException();
        }

        public List<Menu> GetMenusByAuthorId(int userId, int forPageNumber = 0, int perPage = 20)
        {
            throw new NotImplementedException();
        }

        public List<Menu> SearchMenu(string searchString, int forPageNumber = 0, int perPage = 20)
        {
            throw new NotImplementedException();
        }

        public int UpdateMenu(Menu menu)
        {
            throw new NotImplementedException();
        }
    }
}
