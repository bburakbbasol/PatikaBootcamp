using ECommerce.Data;
using ECommerce.Dto;
using ECommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Linq.Expressions;
using System.Text.Json;

namespace ECommerce.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly ECommerceContext _context;


	

	public ProductController(ECommerceContext context)
		{
			_context = context;

		}
		[HttpPut("{productname}")]
		public async Task<IActionResult> UpdateProduct(string productName,ProductUpdateDto UpdateDto)
		{
			var product=await _context.Products.FirstOrDefaultAsync(p=>p.Name==productName);
			if (product != null) return NotFound();

			try
			{
				product.Price=(1+(UpdateDto.PriceIncreasePercentage/100));
				product.StockQuantity += UpdateDto.StockIncrease;
				await _context.SaveChangesAsync();
				return Ok(new
				{
					Message = "Ürün güncellendi",
					ProductName = productName,
					NewPrice= product.Price,
					StockQuantity= product.StockQuantity,
				});
				


			}
			catch (Exception ex)
			{
				
				return StatusCode(500,ex.Message);
			}

			
		


		}


		[HttpPatch("{id}")]
		public async Task<IActionResult>UpdatePrice(int id, [FromBody] JsonPatchDocument<Product> patchDocument)
		{
			if(patchDocument==null) return BadRequest("patch döküman boş olamaz");

			var product= await _context.Products.FindAsync(id);
			if (product == null) return NotFound();
			try
			{
				patchDocument.ApplyTo(product);
				if (product.Price <= 0)
				{
					return BadRequest("Fiyat sıfırdan küçük olamaz");
	
			}
				await _context.SaveChangesAsync();
				return Ok(product);
			}
			catch(DbUpdateConcurrencyException ex)
			{
				var entry=ex.Entries.Single();
				var clientValues = entry.Entity as Product;
				var databaseEntry=entry.GetDatabaseValues();
				if (databaseEntry == null)
				{
					return NotFound();

				}
				var databasaValues =  databaseEntry.ToObject() as Product;
				ModelState.AddModelError(string.Empty, "bu ürün başkası tarafından güncellenmiştir");
				return Conflict(new
				{
					Message = ("Confilct oluştu.Ürün başkası tarafından Güncellenmiştir"),
					CurrentDataValues = databasaValues,
					YourAttemptedValues = databasaValues
				});
					
				
					

			

			}
			catch (Exception ex)
			{
				return StatusCode(500, "Hata oluştu");
			}

		}

	}
}


