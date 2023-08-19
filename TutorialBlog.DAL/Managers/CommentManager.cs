using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialBlog.DAL.Interfaces;
using TutorialBlog.DAL.Model;

namespace TutorialBlog.DAL.Managers
{
    public class CommentManager : ICommentManager
    {
        private TutorialBlogContext _context;
        public CommentManager(TutorialBlogContext context)
        {
            _context = context;
        }
        public Comment CreateComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public int DeleteComment(int id)
        {
            throw new NotImplementedException();
        }

        public Comment GetComment(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetComments(int forPageNumber = 0, int perPage = 20)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetCommentsByAuthorId(int userId, int forPageNumber = 0, int perPage = 20)
        {
            throw new NotImplementedException();
        }

        public List<Comment> SearchComment(string searchString, int forPageNumber = 0, int perPage = 20)
        {
            throw new NotImplementedException();
        }

        public int UpdateComment(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
