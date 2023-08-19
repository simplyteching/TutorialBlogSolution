using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialBlog.DAL.Interfaces;
using TutorialBlog.DAL.Managers;
using TutorialBlog.Service.Interfaces;
using TutorialBlog.WebApi.Entities;
using DALModel = TutorialBlog.DAL.Model;

namespace TutorialBlog.Service.Services
{
    public class UserService : IUserService
    {
        private IUserManager _userManager;
        private IMapper _mapper;
        public UserService(IUserManager userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }
        public User CreateUser(User user)
        {
            DALModel.User dalUser = _mapper.Map<DALModel.User>(user);
            var createdUser = _userManager.CreateUser(dalUser);
            User userToReturn = _mapper.Map<User>(createdUser);
            return userToReturn;
        }

        public int DeleteUser(int userId)
        {
            return _userManager.DeleteUser(userId);
        }

        public User GetUser(int userId)
        {
            var user = _userManager.GetUser(userId);
            return _mapper.Map<User>(user);
        }

        public User GetUserByEmail(string email)
        {
            var user = _userManager.GetUserByEmail(email);
            return _mapper.Map<User>(user);
        }

        public User GetUserByUsername(string username)
        {
            var user = _userManager.GetUserByUsername(username);
            return _mapper.Map<User>(user);
        }

        public List<User> GetUsers(int forPageNumber = 0, int perPage = 20)
        {
            var users = _userManager.GetUsers(forPageNumber, perPage);
            return _mapper.Map<List<User>>(users);
        }

        public List<User> SearchUser(string searchString, int forPageNumber = 0, int perPage = 20)
        {
            var users = _userManager.SearchUser(searchString, forPageNumber, perPage);
            return _mapper.Map<List<User>>(users);
        }

        public int UpdateUser(User user)
        {
            return _userManager.UpdateUser(_mapper.Map<DALModel.User>(user));
        }
    }
}
