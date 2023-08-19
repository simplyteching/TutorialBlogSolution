using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialBlog.DAL.Model;

namespace TutorialBlog.DAL.Interfaces
{
    public interface IMenuManager
    {
        Menu GetMenu(int id);
        Menu CreateMenu(Menu menu);
        List<Menu> GetMenus(int forPageNumber, int perPage);
        List<Menu> GetMenusByAuthorId(int userId, int forPageNumber, int perPage); 
        List<Menu> SearchMenu(string searchString, int forPageNumber, int perPage);
        int UpdateMenu(Menu menu);
        int DeleteMenu(int id);
    }
}
