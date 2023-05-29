using ClassroomHub.Core.Entities;
using System.Collections.Generic;
using System;

namespace ClassroomHub.Services
{
	public interface IActivityService
	{
		void Create(Activity activity);
		List<Activity> GetAll();
		Activity GetById(Guid id);
		void Update(Activity activity);
		void Delete(Guid id);
	}
}
}