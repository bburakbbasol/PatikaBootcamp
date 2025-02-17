using Microsoft.AspNetCore.Mvc;
using Pratik_BasicMVC.Models;

namespace Pratik_BasicMVC.Controllers
{
	public class CustomerOrdersController : Controller
	{
		public IActionResult Index()

		{
			var customer = new Customer
			{
				Id = 1,
				FirstName = "Burak",
				LastName = "Başol",
				Email="bburakbbasol@gmail.com",
			
			};
			var orders = new List<Order>
	{
		new Order { Id = 1, ProductName = "Akhisar Köfte", Price = 280, Quantity = 10 },
		new Order { Id = 2, ProductName = "Ali Nazik", Price = 300, Quantity = 4 },
		new Order { Id = 3, ProductName = "Kelle Paça Çorbası", Price = 200, Quantity = 5 }
	};

			var viewModel = new CustomerOrderViewModel
			{
				Customer = customer,
				Orders = orders.ToList()
			};


			return View(viewModel);
		}
	}
}
