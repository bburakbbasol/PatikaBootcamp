using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratikIlkSınıv
{
	public class Person
	{
		// Kişinin adını, soyadını ve doğum tarihini saklayan özel alanlar
		private string name;
		private string surname;
		private int date;

		// 'Name' özelliği için getter ve setter
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		// 'Surname' özelliği için getter ve setter
		public string Surname
		{
			get { return surname; }
			set { surname = value; }
		}

		// 'Date' özelliği için getter ve setter (Doğum tarihi için doğrulama yapılır)
		public int Date
		{
			get { return date; }
			set
			{
				if (value > 0)
					date = value;
			}
		}

		// Titla göre bilgi oluşturup ekrana yazdıran metod
		public void Create(string title)
		{
			if (title == "öğrenci")
				Console.WriteLine($"{name} adında {surname} soyadında {date} doğumlu öğrenci oluşturuldu ");
			else if (title == "öğretmen")
				Console.WriteLine($"{name} adında {surname} soyadında {date} doğumlu öğretmen oluşturuldu ");
			else
				Console.WriteLine("Oluşturmak istediğiniz yapıyı doğru seçin");
		}
	}
}
