using System.ComponentModel.DataAnnotations;

namespace PatikaCodeFirstDb2.Entites
{
	public class User
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string UserName { get; set; }
		[Required]
		[EmailAddress]
		public string Email { get; set; }
		public List<Post> Posts { get; set; }

	}
}
