using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using JD.TreadHud.Domain.Models;

namespace JD.TreadHud.Domain.Managers
{
    public class ActivityManager : IActivityManager
    {
        private readonly ILogger<ActivityManager> _logger;
        
        public ActivityManager(ILogger<ActivityManager> logger)
        {
            _logger = logger;
        }
		
        public bool AddActivity(Activity activity)
        {
            _logger.LogInformation("Adding activity {@Activity}", activity);
            return true;
        }

        public Activity GetActivity(Guid id)
        {
            _logger.LogInformation("Getting activity with ID {0}", id.ToString());
            return null;
        }

        public IList<Activity> GetAllActivities()
        {
            _logger.LogInformation("Getting all activities.");
            return null;
        }
    }
}