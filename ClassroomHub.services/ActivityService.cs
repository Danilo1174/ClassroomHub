using ClassroomHub.Core.Contracts;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;

namespace ClassroomHub.Services
{
    public class ActivityService : IActivityService
	{
        public void Create(Activity activity) 
        { 

        }
        public void Update(Activity activity)
        {

        }

        public Activity GetById(Guid id)
        {
            return new Activity();
        }
        public List<Activity> GetAll()
        {
            return new List<Activity>();    
        }
        public void Delete(Guid id)
        {

        }
    }
}
