using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialBlog.DAL.Interfaces;
using DALModel = TutorialBlog.DAL.Model;
using TutorialBlog.Service.Interfaces;
using TutorialBlog.WebApi.Entities;

namespace TutorialBlog.Service.Services
{
    public class ActivityService : IActivityService
    {
        private IActivityManager _activityManager;
        private IMapper _mapper;
        public ActivityService(IActivityManager activityManager, IMapper mapper) 
        {
            _mapper = mapper;
            _activityManager = activityManager;
        }
        public Activity CreateActivity(Activity activity)
        {
            DALModel.Activity dalActivity = _mapper.Map<DALModel.Activity>(activity);
            var createdActivity = _activityManager.CreateActivity(dalActivity);
            Activity activityToReturn = _mapper.Map<Activity>(createdActivity);
            return activityToReturn;
        }

        public int DeleteActivity(int id)
        {
            return _activityManager.DeleteActivity(id);
        }

        public List<Activity> GetActivityByAuthor(int userId, int forPageNumber = 0, int perPage = 20)
        {
            var activities = _activityManager.GetActivityByAuthor(userId, forPageNumber, perPage);
            return _mapper.Map<List<Activity>>(activities);
        }
    }
}
