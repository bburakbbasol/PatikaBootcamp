using Microsoft.EntityFrameworkCore;
using Survivor.Models;

namespace Survivor.Data
{
	public class SurvivorContext:DbContext

	{
		public SurvivorContext(DbContextOptions<SurvivorContext> options) : base(options) { }

		public DbSet<Category> Categories { get; set; }
		public DbSet<Competitor> Competitors { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Competitor>()
						.HasOne(c => c.Category)
						.WithMany(c => c.Competitors)
						.HasForeignKey(c => c.CategoryId);
		}

	}
}
