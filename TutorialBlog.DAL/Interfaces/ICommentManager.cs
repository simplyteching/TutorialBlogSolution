using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialBlog.DAL.Model;

namespace TutorialBlog.DAL.Interfaces
{
    public interface ICommentManager
    {
        Comment GetComment(int id);
        Comment CreateComment(Comment comment);
        List<Comment> GetComments(int forPageNumber, int perPage);
        List<Comment> GetCommentsByAuthorId(int userId, int forPageNumber, int perPage);
        List<Comment> SearchComment(string searchString, int forPageNumber, int perPage);
        int UpdateComment(Comment comment);
        int DeleteComment(int id);
    }
}
