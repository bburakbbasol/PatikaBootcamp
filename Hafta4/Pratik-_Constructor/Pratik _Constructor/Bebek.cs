using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
namespace Pratik__Constructor 
{
	public class Bebek // Bebek sınıfı tanımlanıyor.
	{
		public string Isim { get; set; } // Bebek ismi.
		public string Soyisim { get; set; } // Bebek soyismi.
		public DateTime DogumTarih { get; set; } // Bebek doğum tarihi.

		public Bebek() // Parametresiz yapıcı metot.
		{
			Console.WriteLine("ıngaaaaaaaaaaaaaaaaaaaaaah " + DateTime.Now); // Mesaj ve tarih yazdırır.
		}

		public Bebek(string isim, string soyisim, DateTime dateTime) // Parametreli yapıcı metot.
		{
			Isim = isim; // İsim atanıyor.
			Soyisim = soyisim; // Soyisim atanıyor.
			DogumTarih = dateTime; // Doğum tarihi atanıyor.
			Console.WriteLine("ıngaaaaaaaaaaaaaaaaaaaaaah " + DateTime.Now); // Mesaj ve tarih yazdırır.
		}
	}
}