using System.ComponentModel;
using System.Collections.Generic;
using ClassroomHub.Core.Entities;
using System;

namespace ClassroomHub.Core.Contracts.Services
{
    public interface IClassService
	{
        IEnumerable<Class> GetAll();
		void Add(Class entity);
        void Update(Class classe);
        Class GetById(Guid id);

        void Delete(Guid id);
    }
}
