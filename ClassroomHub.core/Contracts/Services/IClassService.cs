﻿using System.ComponentModel;
using System.Collections.Generic;
using ClassroomHub.Core.Entities;
using System;

namespace ClassroomHub.Core.Contracts.Services
{
    public interface IClassService
	{
		IEnumerable<Class> GetAll();
		IEnumerable<Class> GetAllByCourseId(Guid courseId);
		Class GetById(Guid id);
		void Add(Class entity);
		void Update(Class entity);
		void Delete(Guid id);
	}
}
