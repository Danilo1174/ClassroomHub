using System;
using System.Collections.Generic;
using System.Text;
using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClassroomHub.Data
{
	public class Context : DbContext
	{
		
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ClassroomHubDB;Trusted_Connection=True;");

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);

		}



	}
}
