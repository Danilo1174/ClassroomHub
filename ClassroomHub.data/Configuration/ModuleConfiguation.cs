using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Data.Configuration 
{
	internal class ModuleConfiguation : IEntityTypeConfiguration<Module>
	{
		public void Configure(EntityTypeBuilder<Module> builder)
		{
			builder.ToTable("Modules");
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
			builder.Property(x => x.Description).HasMaxLength(100).IsRequired();
			builder.Property(x => x.Start).IsRequired();
			builder.Property(x => x.End).IsRequired();
			builder.HasOne(x => x.Teacher).WithMany(x => x.Modules).HasForeignKey(x => x.TeacherId);


			
			

		}
	}
}
