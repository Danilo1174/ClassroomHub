using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Services
{
	public class ClassService : IClassService
	{
		private readonly IClassRepository _classRepository;
        public ClassService(IClassRepository classRepository)
        {
			_classRepository = classRepository; 
        }
        public IEnumerable<Class> GetAll()
		{
			return _classRepository.GetAll();
		}
		public void Add(Class entity)
		{
			_classRepository.Add(entity);
		}
	}
}
