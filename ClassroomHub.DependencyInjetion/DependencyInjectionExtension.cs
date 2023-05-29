using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using ClassroomHub.Core.Contracts;
using Microsoft.Extensions.DependencyInjection;


namespace ClassroomHub.DependencyInjetion
{
	public class DependencyInjectionExtension
	{
		public static void AddServicesDependecy(this IServiceCollection services)
		{
			services.AddScoped<IUserService, UserService>();

		}
		
	}
}
