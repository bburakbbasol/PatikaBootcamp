namespace ECommerce.Dto
{
	public class CreateOrderDto
	{
		public int CustomerId { get; set; }
		public List<(int productId, int quantity)>  OrderItems{  get; set; }
	}
}
