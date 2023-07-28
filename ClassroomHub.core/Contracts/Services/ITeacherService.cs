using ClassroomHub.Core.Entities;
using System.Collections.Generic;
using System;

namespace ClassroomHub.Core.Contracts.Services
{
    public interface ITeacherService
    {

        IEnumerable<Teacher> GetAll();
		void Create(Teacher teacher);

	}
}