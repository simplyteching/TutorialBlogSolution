using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialBlog.DAL.Model;

namespace TutorialBlog.DAL.Interfaces
{
    public interface IBlogManager
    {
        Blog GetBlog(int blogId);
        Blog CreateBlog(Blog blog);
        List<Blog> GetBlogs(int forPageNumber, int perPage);
        List<Blog> GetBlogByAuthor(int userId, int forPageNumber, int perPage);
        List<Blog> SearchBlog(string searchString, int forPageNumber, int perPage);
        int UpdateBlog(Blog blog);
        int DeleteBlog(int id);
    }
}
