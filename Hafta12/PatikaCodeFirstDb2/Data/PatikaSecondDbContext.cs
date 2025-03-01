using Microsoft.EntityFrameworkCore;
using PatikaCodeFirstDb2.Entites;

namespace PatikaCodeFirstDb2.Data
{
	public class PatikaSecondDbContext:DbContext
	{
	 public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options) : base(options) {}
		
		public DbSet<User > Users { get; set; }
		public DbSet<Post> Posts { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<User>(entity =>
			entity.HasMany(e => e.Posts)
				   .WithOne(e => e.User)
				   .HasForeignKey(e => e.UserId)
				   .OnDelete(DeleteBehavior.Cascade)
			);
		}

	}
}
