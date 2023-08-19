using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialBlog.DAL.Interfaces;
using TutorialBlog.DAL.Model;

namespace TutorialBlog.DAL.Managers
{
    public class ActivityManager : IActivityManager
    {
        private TutorialBlogContext _context;
        public ActivityManager(TutorialBlogContext context)
        {
            _context = context;
        }
        public Activity CreateActivity(Activity activity)
        {
            _context.Activities.Add(activity);
            activity.ActivityId = _context.SaveChanges();
            return activity;
        }

        public int DeleteActivity(int id)
        {
            Activity activity = _context.Activities.Where(x => x.ActivityId == id).FirstOrDefault();
            if (activity != null)
            {
                _context.Activities.Remove(activity);
                return 1;
            }
            return 0;
        }

        public Activity GetActivity(int ActivityId)
        {
            return _context.Activities.Where(x => x.ActivityId == ActivityId).FirstOrDefault();
        }

        public List<Activity> GetActivityByAuthor(int userId, int forPageNumber = 0, int perPage = 20)
        {
            return _context.Activities.Where(x => x.UserId == userId).ToList();
        }
    }
}
