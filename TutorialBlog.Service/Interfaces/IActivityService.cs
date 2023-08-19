using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialBlog.WebApi.Entities;

namespace TutorialBlog.Service.Interfaces
{
    public interface IActivityService
    {
        Activity CreateActivity(Activity activity);
        List<Activity> GetActivityByAuthor(int userId, int forPageNumber = 0, int perPage = 20);
        int DeleteActivity(int id);
    }
}
