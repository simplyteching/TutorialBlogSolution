using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialBlog.WebApi.Entities;

namespace TutorialBlog.Service.Interfaces
{
    public interface IUserService
    {
        User GetUser(int id);
        User CreateUser(User user);
        User GetUserByUsername(string username);
        User GetUserByEmail(string email);
        List<User> GetUsers(int forPageNumber = 0, int perPage = 20);
        List<User> SearchUser(string searchString, int forPageNumber = 0, int perPage = 20);
        int UpdateUser(User user);
        int DeleteUser(int id);
    }
}
