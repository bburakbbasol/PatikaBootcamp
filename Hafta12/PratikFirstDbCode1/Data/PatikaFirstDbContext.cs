using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using PratikFirstDbContext.Entites;

namespace PratikFirstDbContext.Data
{
	public class PatikaFirstDbContext:DbContext
	{
		public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options)
		{

		}
		public DbSet<Game> Games { get; set; }
		public DbSet<Movie> Movies { get; set; }

	}
}
