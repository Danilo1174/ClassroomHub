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
			builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
			builder.
			

		}
	}
}
