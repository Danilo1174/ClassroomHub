using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

namespace ClassroomHub.Data.Configuration
{
	internal class StudentConfiguration : IEntityTypeConfiguration<Student>
	{
		public void Configure(EntityTypeBuilder<Student> builder)
		{
			builder.ToTable("Students");
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
			builder.Property(x => x.Surname).HasMaxLength(100).IsRequired();
			builder.Property(x => x.Birthday).IsRequired();
			builder.HasOne(x => x.Class).WithMany(x => x.Students).HasForeignKey(x => x.ClassId);
			builder.HasOne(x => x.User).WithOne(x => x.Student).HasForeignKey<Student>(x => x.UserId);



		}
	}
}
