using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TutorialBlog.Service.Interfaces;
using TutorialBlog.WebApi.Entities;

namespace TutorialBlog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private IActivityService _activityService;
        public ActivityController(IActivityService activityService) {
            _activityService = activityService;
        }

        [HttpGet]
        public IEnumerable<Activity> Index() {
            User user = new User()
            {
                UserId = 1
            };
            return _activityService.GetActivityByAuthor(user.UserId);
        }
        
    }
}
