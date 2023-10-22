using Microsoft.EntityFrameworkCore;
using DatabaseConnection.MODEL.Entities;
using System.Reflection;

namespace DatabaseConnection.DAL.Context
{
	public class MyConnectionDbContext:DbContext
	{
		public MyConnectionDbContext(DbContextOptions options):base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}

		public DbSet<MyTable> tables { get; set; }

	}
}
