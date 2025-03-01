using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatikaCodeFirstDb2.Entites
{
	public class Post
	{
		[Key]
		public int Id { get; set; }
		[Required]	
		public string Title { get; set; }

		public string Content { get; set; }
		[ForeignKey("User")]
		public int UserId { get; set; }
		public User User { get; set; }

	}
}
