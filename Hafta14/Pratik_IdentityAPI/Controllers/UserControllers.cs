using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Pratik_IdentityAPI.Data;
using System.Threading.Tasks;
using Pratik_IdentityAPI.Model;

namespace Pratik_IdentityAPI.Controllers
{
	// API'yi yöneten controller sınıfı
	[Route("api/[controller]")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		// Kullanıcı yönetimi ve giriş için gerekli olan servislere ait referanslar
		private readonly UserManager<IdentityUser> _userManager;
		private readonly SignInManager<IdentityUser> _signInManager;

		// Controller'ın yapıcı metodunda servislere bağımlılık enjeksiyonu yapılır
		public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}

		// Kullanıcı kaydını yapacak olan API metodunun tanımlandığı yer
		[HttpPost("register")]
		public async Task<IActionResult> Register([FromBody] RegisterModel model)
		{
			// Model geçerli mi diye kontrol eder
			if (ModelState.IsValid)
			{
				// Yeni bir kullanıcı oluşturulur
				var user = new IdentityUser { UserName = model.Email, Email = model.Email };

				// Kullanıcıyı veritabanına ekler, şifresini belirler
				var result = await _userManager.CreateAsync(user, model.Password);

				// Eğer işlem başarılıysa başarılı mesajı döner
				if (result.Succeeded)
				{
					return Ok(new { message = "User registered successfully." });
				}

				// Eğer işlem başarısızsa, hata mesajlarını ModelState'e ekler
				foreach (var error in result.Errors)
				{
					ModelState.AddModelError(string.Empty, error.Description);
				}
			}

			// Eğer model geçerli değilse veya işlem başarısızsa, hata mesajları döner
			return BadRequest(ModelState);
		}

		// Kullanıcı girişi işlemi için API metodu
		[HttpPost("login")]
		public async Task<IActionResult> Login([FromBody] LoginModel model)
		{
			// Model geçerli mi kontrol edilir
			if (ModelState.IsValid)
			{
				// Email'e göre kullanıcıyı veritabanından bulur
				var user = await _userManager.FindByEmailAsync(model.Email);

				// Eğer kullanıcı bulunmuşsa ve şifre doğruysa giriş yapılır
				if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
				{
					// Kullanıcıyı oturum açmış olarak işaretler
					await _signInManager.SignInAsync(user, isPersistent: false);
					return Ok(new { message = "Login successful." });
				}

				// Eğer giriş başarısızsa, hatalı giriş mesajı döner
				return Unauthorized(new { message = "Invalid login attempt." });
			}

			// Eğer model geçerli değilse, hata mesajları döner
			return BadRequest(ModelState);
		}
	}
}
