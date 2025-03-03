namespace Survivor.Models
{
	public abstract class BaseModels<T>
	{
		public T Id { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime ModifiedDate { get; set; }

		public bool IsDeleted { get; set; }

	}
}
