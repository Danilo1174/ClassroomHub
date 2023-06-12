using Microsoft.EntityFrameworkCore;

namespace ClassroomHub.Data
{
	public class Context : DbContext
	{

		private readonly string _ConnectionString;
        public Context(DbContextOptions options): base(options) 
		{

		}
		public Context( string connectionsString, DbContextOptions options) : this(options)
		{
			_ConnectionString = connectionsString; 
		}



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!string.IsNullOrEmpty(_ConnectionString))
			{

				optionsBuilder.UseSqlServer(_ConnectionString);
			}


		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);

		}



	}
}
