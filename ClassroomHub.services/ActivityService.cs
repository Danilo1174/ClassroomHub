﻿using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Contracts.Repositories;
using System.Collections.Generic;
using ClassroomHub.Core.Entities;
using System;

namespace ClassroomHub.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IActivityRepository _activityRepository;

        public ActivityService(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }

        public void Add(Activity activity)
        {
            _activityRepository.Add(activity);
        }

        public IEnumerable<Activity> GetAllWithModules()
        {
            return _activityRepository.GetAllWithModules();
        }

		public IEnumerable<Activity> GetAllWithModules(Guid teacherId)
		{
			throw new NotImplementedException();
		}

		public Activity GetById(Guid id) =>
            _activityRepository.GetById(id);

    }
}
