using ClassroomHub.Core.Entities;
using System.Collections.Generic;
using System;

namespace ClassroomHub.Services
{
	public interface ITeacherService
	{
		void Create(Teacher teacher);
		List<User> GetAll();
		User GetById(Guid id);
		void Update(Teacher teacher);
		void Delete(Guid id);
	}
}