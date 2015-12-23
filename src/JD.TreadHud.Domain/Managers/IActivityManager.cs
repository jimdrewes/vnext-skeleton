using System;
using System.Collections.Generic;
using JD.TreadHud.Domain.Models;

namespace JD.TreadHud.Domain.Managers
{
	public interface IActivityManager
	{
        IList<Activity> GetAllActivities();
        Activity GetActivity(Guid id);
        bool AddActivity(Activity activity);
    }
}