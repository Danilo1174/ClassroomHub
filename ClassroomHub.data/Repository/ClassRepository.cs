using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Data.Repository
{
	public class ClassRepository : BaseRepository<Class>, IClassRepository
	{
		public ClassRepository(Context context) : base(context)
		{
		}
	}
}
