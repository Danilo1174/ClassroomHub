using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Data.Configuration
{
	internal class TeacherConfiguration : IEntityTypeConfiguration<Teacher>

	{
		public void Configure(EntityTypeBuilder<Teacher> builder)
		{
			builder.ToTable("Teachers");
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
			builder.Property(x => x.Surname).HasMaxLength(100).IsRequired();
			builder.Property(x => x.Email).HasMaxLength(80).IsRequired();
			builder.HasOne(x => x.User).WithOne(x => x.Teacher).HasForeignKey<Teacher>(x => x.UserId);
			
		}
	}
}
