using ECommerce.Data;
using ECommerce.Dto;
using ECommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Reflection.Metadata.Ecma335;

namespace ECommerce.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrdersController : ControllerBase
	{
		private readonly ECommerceContext _context;
		public OrdersController(ECommerceContext context)
		{
			_context = context;
		}
		[HttpGet("{id}")]
		public async Task<ActionResult<Order>> GetByInt(int id)
		{
			var order = _context.Orders.Include(o => o.Customer)
				                        .Include(o=>o.OrderDetails)
										.ThenInclude(od=>od.Product)
										.FirstOrDefaultAsync(o=>o.Id== id);
			if (order == null) return NotFound();

			return Ok(order);
		}
		[HttpPost]
		public async Task<ActionResult<Order>>Create(CreateOrderDto order) 
		{
			//_context.Orders.Add(order);
		
		using var transaction = await _context.Database.BeginTransactionAsync();
			try
			{
				var newOrder = new Order
				{
					CustomerId = order.CustomerId,
					OrderDate = DateTime.Now,
					TotalAmount = 0
				};
				_context.Add(newOrder);
				await _context.SaveChangesAsync();
				decimal totalAmount = 0;


				foreach(var item in order.OrderItems)
				{
					var product = await _context.Products.FindAsync(item.productId);
					if (product == null) throw new Exception($"{item.productId} ıdli ürün bulunamadı");
					if (product.StockQuantity < item.quantity) throw new Exception($"{item.productId} üründen yeterli stok yok");
					var orderDetail = new OrderDetail
					{
						OrderId = newOrder.Id,
						ProductId = product.Id,
						Quantity = item.quantity,
						UnitPrice = product.Price
					};
					_context.OrderDetails.Add(orderDetail);
					totalAmount += orderDetail.Quantity * orderDetail.UnitPrice;
					product.StockQuantity -= item.quantity;
					_context.Products.Update(product);

				}
				newOrder.TotalAmount = totalAmount;
				_context.Orders.Update(newOrder);
				await _context.SaveChangesAsync();
				await  transaction.CommitAsync();
				return CreatedAtAction(nameof(Order),new { id = newOrder.Id },newOrder );

			}

			catch (Exception ex)
			{
				transaction.Rollback();
				throw ex;
			}
			


		}
		[HttpDelete("deletold")]
		public async Task<IActionResult> DeletOldOrders([FromQuery] int yearsOld = 1)
		{
			if (yearsOld < 0) return BadRequest("Yıl Bilgisi pozitif sayı olmalıdır");
			var cuttoffDate=DateTime.Now.AddYears(-yearsOld);
			int totalDeletedCount = 0;
			using var transaction=await _context.Database.BeginTransactionAsync();
			try
			{
				int batchSize = 1000;
				bool continueDeletion = true;
				while (continueDeletion)
				{
					var oldOrders=await _context.Orders
											.Where(o=>o.OrderDate == cuttoffDate)
											.Include(o=> o.OrderDetails)
											.Take(batchSize).ToListAsync();


					if (!oldOrders.Any())
					{
						continueDeletion = false;
						continue;
					}

					foreach(var oldOrder in oldOrders)
					{
						_context.OrderDetails.RemoveRange(oldOrder.OrderDetails);
					}
					_context.Orders.RemoveRange(oldOrders);
					var deletedCount=await _context .SaveChangesAsync();
					totalDeletedCount=deletedCount;


				}
				await transaction.CommitAsync();
				return Ok($"{ totalDeletedCount} silindi");

			}
			catch
			{
				transaction.Rollback();
				return StatusCode(500, "Bir Hata Oluştu");
			}

			
		}
	}
}
