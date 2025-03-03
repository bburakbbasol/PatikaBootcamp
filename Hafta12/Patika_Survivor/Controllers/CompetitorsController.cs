using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Survivor.Data;
using Survivor.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Survivor.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CompetitorsController : ControllerBase
	{
		private readonly SurvivorContext _context;

		public CompetitorsController(SurvivorContext context)
		{
			_context = context;
		}

		private async Task<Competitor?> FindCompetitorByIdAsync(int id)
		{
			return await _context.Competitors.FirstOrDefaultAsync(x => x.Id == id);
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Competitor>>> GetAll()
		{
			var competitors = await _context.Competitors.AsNoTracking().ToListAsync();
			if (competitors == null || competitors.Count == 0) return NotFound("Hiç yarışmacı bulunamadı.");
			return Ok(competitors);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Competitor>> GetById(int id)
		{
			var competitor = await FindCompetitorByIdAsync(id);
			if (competitor == null) return NotFound($"ID {id} olan yarışmacı bulunamadı.");
			return Ok(competitor);
		}

		[HttpGet("categories/{categoryId}")]
		public async Task<ActionResult<IEnumerable<Competitor>>> GetByCategory(int categoryId)
		{
			var competitors = await _context.Competitors
											.Where(c => c.CategoryId == categoryId)
											.ToListAsync();

			if (competitors == null || competitors.Count == 0)
				return NotFound($"ID {categoryId} olan kategoriye ait yarışmacı bulunamadı.");

			return Ok(competitors);
		}

		[HttpPost]
		public async Task<ActionResult<Competitor>> Create([FromBody] Competitor newCompetitor)
		{
			if (newCompetitor == null) return BadRequest("Geçersiz yarışmacı verisi.");

			_context.Competitors.Add(newCompetitor);
			await _context.SaveChangesAsync();

			return CreatedAtAction(nameof(GetById), new { id = newCompetitor.Id }, newCompetitor);
		}

		[HttpPut("{id}")]
		public async Task<ActionResult> Update(int id, [FromBody] Competitor updateCompetitor)
		{
			var competitor = await FindCompetitorByIdAsync(id);
			if (competitor == null) return NotFound($"ID {id} olan yarışmacı bulunamadı.");

			competitor.FirstName = updateCompetitor.FirstName;
			competitor.LastName = updateCompetitor.LastName;
			competitor.CategoryId = updateCompetitor.CategoryId;

			await _context.SaveChangesAsync();
			return Ok($"ID {id} olan yarışmacı başarıyla güncellendi.");
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var competitor = await FindCompetitorByIdAsync(id);
			if (competitor == null) return NotFound($"ID {id} olan yarışmacı bulunamadı.");

			_context.Competitors.Remove(competitor);
			await _context.SaveChangesAsync();

			return Ok($"ID {id} olan yarışmacı başarıyla silindi.");
		}
	}
}
