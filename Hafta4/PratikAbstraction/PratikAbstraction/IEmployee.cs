using System;

namespace PratikAbstraction
{
	// IEmployee arayüzü, tüm çalışanlar için ortak özellik ve metotları tanımlar
	public interface IEmployee
	{
		public string Name { get; set; } // Çalışanın adı
		public string Surname { get; set; } // Çalışanın soyadı
		void Title(); // Çalışanın unvanını yazdıran metot
	}

	// Yazılım Geliştirici sınıfı, IEmployee arayüzünü uygular
	public class SoftwareDevoloper : IEmployee
	{
		public string Name { get; set; } // Ad özelliği
		public string Surname { get; set; } // Soyad özelliği

		// Constructor, ad ve soyadı atar
		public SoftwareDevoloper(string name, string surname)
		{
			Name = name;
			Surname = surname;
		}

		// Yazılım Geliştirici için unvanı yazdırır
		public void Title()
		{
			Console.WriteLine($"{Name} {Surname} Software Devoloper");
		}
	}

	// Proje Yöneticisi sınıfı, IEmployee arayüzünü uygular
	public class ProjectManager : IEmployee
	{
		public string Name { get; set; } // Ad özelliği
		public string Surname { get; set; } // Soyad özelliği

		// Constructor, ad ve soyadı atar
		public ProjectManager(string name, string surname)
		{
			Name = name;
			Surname = surname;
		}

		// Proje Yöneticisi için unvanı yazdırır
		public void Title()
		{
			Console.WriteLine($"{Name} {Surname} Project Manager");
		}
	}

	// Satış Temsilcisi sınıfı, IEmployee arayüzünü uygular
	public class SalesRepresentative : IEmployee
	{
		public string Name { get; set; } // Ad özelliği
		public string Surname { get; set; } // Soyad özelliği

		// Constructor, ad ve soyadı atar
		public SalesRepresentative(string name, string surname)
		{
			Name = name;
			Surname = surname;
		}

		// Satış Temsilcisi için unvanı yazdırır
		public void Title()
		{
			Console.WriteLine($"{Name} {Surname} Sales Representative");
		}
	}
}
