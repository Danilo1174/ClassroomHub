using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomHub.Data.Repositories
{
	public class ClassRepository : BaseRepository<Class>, IClassRepository
	{
		public ClassRepository(Context context) : base(context)
		{

		}
        public IEnumerable<Class> GetClassesByCourseId(Guid courseId)
        {
            return this.GetAll().Where(x => x.CourseId == courseId);
        }
    }
}
