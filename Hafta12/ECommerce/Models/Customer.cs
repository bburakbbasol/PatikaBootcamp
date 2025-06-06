﻿namespace ECommerce.Models
{
	public class Customer
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }

		public DateTime SignUpDate { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

	}
}
