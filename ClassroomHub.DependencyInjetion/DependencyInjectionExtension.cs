﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Services;
using Microsoft.Extensions.DependencyInjection;
using ClassroomHub.Data.Repositories;


namespace ClassroomHub.DependencyInjetion
{
    public static  class DependencyInjectionExtension
	{
		public static void AddServicesDependency(this IServiceCollection services)
		{
			services.AddScoped<IUserService, UserService>();
			services.AddScoped<IStudentService, StudentService>();
			services.AddScoped<ITeacherService, TeacherService>();
			services.AddScoped<IActivityService, ActivityService>();
			services.AddScoped<IClassService, ClassService>();
			services.AddScoped<ICourseService, CourseService>();
			services.AddScoped<IDeliveryService, DeliveryService>();
			services.AddScoped<IModuleService, ModuleService>();

		}
		public static void AddRepositoryDependency(this IServiceCollection services)
		{
			services.AddScoped<IUserRepository, UserRepository>();
			services.AddScoped<IStudentRepository, StudentRepository>();
			services.AddScoped<IClassRepository, ClassRepository>();
			services.AddScoped<ICourseRepository, CourseRepository>();
			services.AddScoped<ITeacherRepository, TeacherRepository>();
			services.AddScoped<IModuleRepository, ModuleRepository>();
            services.AddScoped<IActivityRepository, ActivityRepository>();
			services.AddScoped<IDeliveryRepository, DeliveryRepository>();
		}

	}
}
