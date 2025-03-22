using Pratik_DI.Interfaces;

namespace Pratik_DI.Services
{
	public class Teacher : IOgretmen
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public Teacher(string firstName,string lastName)
		{
			FirstName = firstName;
			LastName = lastName;

			
		}

		string IOgretmen.GetInfo()
		{

			return ($"{FirstName} {LastName}");
		}
	}
}
