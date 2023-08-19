using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialBlog.DAL.Interfaces;
using TutorialBlog.DAL.Model;

namespace TutorialBlog.DAL.Managers
{
    public class BlogManager : IBlogManager
    {
        private TutorialBlogContext _context;
        public BlogManager(TutorialBlogContext context)
        {
            _context = context;
        }
        public Blog CreateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public int DeleteBlog(int id)
        {
            throw new NotImplementedException();
        }

        public Blog GetBlog(int blogId)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogByAuthor(int userId, int forPageNumber = 0, int perPage = 20)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogs(int forPageNumber = 0, int perPage = 20)
        {
            throw new NotImplementedException();
        }

        public List<Blog> SearchBlog(string searchString, int forPageNumber = 0, int perPage = 20)
        {
            throw new NotImplementedException();
        }

        public int UpdateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
