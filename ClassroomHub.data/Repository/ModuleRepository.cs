using System;
using System.Collections.Generic;
using System.Text;
using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Entities;


namespace ClassroomHub.Data.Repositories
{
	public class ModuleRepository : BaseRepository<Module>, IModuleRepository
	{
		public ModuleRepository(Context context): base(context)
		{
		}

	}
}
