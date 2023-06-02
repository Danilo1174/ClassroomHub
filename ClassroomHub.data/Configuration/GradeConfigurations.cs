using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Data.Configuration
{
	internal class GradeConfigurations : IEntityTypeConfiguration<Grade>
	{
		public void Configure(EntityTypeBuilder<Grade> builder)
		{
			builder.ToTable("Grade");
			builder.HasKey(x => x.Id);
			builder.Property(x=> x.GradeValue).IsRequired();
			
		}
	}
}
