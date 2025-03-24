using System.ComponentModel.DataAnnotations;

namespace Pratik_IdentityAPI.Model
{
	public class RegisterModel
	{
		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		[MinLength(6)]
		public string Password { get; set; }
	}
}
