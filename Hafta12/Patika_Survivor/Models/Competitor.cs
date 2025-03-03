using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace Survivor.Models
{
	public class Competitor:BaseModels<int>
	{
		public string FirstName {  get; set; }
		public string LastName { get; set; }
		[ForeignKey(nameof(CategoryId))]
		public int CategoryId { get; set; }

		public Category Category { get; set; }


		
	}
}
