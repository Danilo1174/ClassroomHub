using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Core.Contracts.Services
{
	public interface IStudentService
	{
		IEnumerable<Student> GetAll();
		void Add( Student student );
		void Update( Student student );
		void Delete( Student student );
	}
}
