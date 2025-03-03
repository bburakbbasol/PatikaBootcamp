using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Survivor.Data;
using Survivor.Models;

namespace Survivor.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriesController : ControllerBase
	{
		private readonly SurvivorContext _context;

		public CategoriesController(SurvivorContext context)
		{
			_context = context;
			
		}
		[HttpGet]
		public IActionResult GetAll()
		{
			var categories = _context.Categories.AsNoTracking().ToList();
			if (!categories.Any()) 
			{
				return NotFound("No categories found.");
			}
			return Ok(categories); // `Ok()` tüm listeyi döndürür
		}
		[HttpGet("{id}")]
		public async Task<ActionResult<Category>> GetById(int id)
		{
			var category = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
			if (category == null) return NotFound($"{id} not found");
			return Ok(category);

		}
		[HttpPost]
		public async Task<ActionResult<Category>> Create(Category category)
		{
			_context.Categories.Add(category);
			await _context.SaveChangesAsync();
			var newCompetitor = new Competitor
			{
				CategoryId = category.Id,
				FirstName = "Ad ",
				LastName = "Soyad"
			};

			_context.Competitors.Add(newCompetitor);
			await _context.SaveChangesAsync();
			return CreatedAtAction(nameof(GetById),new {id=category.Id},category);

		}
		[HttpPut("{Name}")]

		public async Task<ActionResult<Category>> Update(string name, [FromBody] Category updateCategory)

		{
			var category= await _context.Categories.FirstOrDefaultAsync(c => c.Name == name);
			if (category == null) return NotFound("Kategori bulunamadı");
			category.Name = updateCategory.Name?? category.Name;
			await _context.SaveChangesAsync();
			return Ok(category);
			

		}
		[HttpDelete("{id}")]
		public async Task<ActionResult<Category>>Delete(int id)
		{
			var category=await _context.Categories.FindAsync(id);

			if (category == null) return NotFound($"ID {id} olan kategori bulunamadı.");
			_context.Categories.Remove(category);
			await _context.SaveChangesAsync();
			
			return Ok($"Kategori {id} başarıyla silindi.");



		}

	}
}
