namespace Survivor.Models
{
	public class Category:BaseModels<int>
	{
		public string Name { get; set; }	
		public List<Competitor> Competitors { get; set;} 
	}
}
