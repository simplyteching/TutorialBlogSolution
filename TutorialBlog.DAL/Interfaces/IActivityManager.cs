using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialBlog.DAL.Model;

namespace TutorialBlog.DAL.Interfaces
{
    public interface IActivityManager
    {
        Activity GetActivity(int ActivityId);
        Activity CreateActivity(Activity activity);
        List<Activity> GetActivityByAuthor(int userId, int forPageNumber, int perPage);
        int DeleteActivity(int id);
    }
}
