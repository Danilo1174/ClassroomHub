using System.ComponentModel;
using System.Collections.Generic;
using ClassroomHub.Core.Entities;

namespace ClassroomHub.Core.Contracts.Services
{
    public interface IClassService
	{
        IEnumerable<Class> GetAll();
		void Add(Class entity);
	}
}
