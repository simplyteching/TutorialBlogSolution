using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialBlog.DAL.Interfaces;
using TutorialBlog.DAL.Model;

namespace TutorialBlog.DAL.Managers
{
    public class UserManager : IUserManager
    {
        private TutorialBlogContext _context;
        public UserManager(TutorialBlogContext context)
        {
            _context = context;
        }
        public User CreateUser(User user)
        {
            _context.Users.Add(user);
            user.UserId = _context.SaveChanges();
            return user;      
        }

        public int DeleteUser(int id)
        {
            User user = _context.Users.Where(x => x.UserId == id).FirstOrDefault();
            if (user != null)
            {
                _context.Users.Remove(user);
                return 1;
            }
            return 0;
        }

        public User GetUser(int id)
        {
            return _context.Users.Where(x => x.UserId == id).FirstOrDefault();
        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.Where(x => x.Email == email).FirstOrDefault();
        }

        public User GetUserByUsername(string username)
        {
            return _context.Users.Where(x => x.Username == username).FirstOrDefault();
        }

        public List<User> GetUsers(int forPageNumber = 1, int perPage = 20)
        {
            return _context.Users.Skip(forPageNumber*perPage).Take(perPage).ToList();
        }

        public List<User> SearchUser(string searchString, int forPageNumber = 0, int perPage = 20)
        {
            return _context.Users.Where(x => x.Name.Contains(searchString)).Skip(forPageNumber * perPage).Take(perPage).ToList();
        }

        public int UpdateUser(User user)
        {
             _context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
             return _context.SaveChanges();
        }
    }
}
