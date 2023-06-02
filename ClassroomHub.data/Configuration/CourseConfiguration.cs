using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Data.Configuration
{
	internal class CourseConfiguration : IEntityTypeConfiguration<Course>
	{
		public void Configure(EntityTypeBuilder<Course> builder)
		{
			builder.ToTable("Courses");
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Name).IsRequired();
			builder.Property(x => x.Description).IsRequired();	
			
		}
	}
}
