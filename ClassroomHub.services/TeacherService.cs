using ClassroomHub.Core.Contracts;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;

namespace ClassroomHub.Services
{
    public class TeacherService : ITeacherService
    {
        public void Create(Teacher teacher) 
        { 

        }
        public void Update(Teacher teacher)
        {

        }

        public Teacher GetById(Guid id)
        {
            return new Teacher();
        }
        public List<Teacher> GetAll()
        {
            return new List<Teacher>();    
        }
        public void Delete(Guid id)
        {

        }

		List<User> ITeacherService.GetAll()
		{
			throw new NotImplementedException();
		}

		User ITeacherService.GetById(Guid id)
		{
			throw new NotImplementedException();
		}
	}
}
