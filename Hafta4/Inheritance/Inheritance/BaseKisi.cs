using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	// Temel kişi sınıfı
	public abstract class BaseKisi
	{
		public string  Ad { get; set; }
		public string Soyad { get; set; }

		public  void  Yazdir()
		{
			Console.Write($"{Ad} {Soyad}");

		}
		 
		

	}
	// Ogrenci sınıfı, BaseKisi'den türetilir
	public class Ogrenci : BaseKisi
	{
		public  int  OgrenciNumarasi  { get; set; }

		public void  OgrenciBilgi()
		{
			Yazdir();
			Console.WriteLine($": {OgrenciNumarasi} numaralı öğrenci ");
		}
	}
	// Ogretmen sınıfı, BaseKisi'den türetilir
	public class Ogretmen : BaseKisi
	{
		public int Maas { get; set; }
		
		public void OgretmenBilgi()
		{
			Yazdir() ;
			Console.WriteLine($" hocamız bu aylık Maaşı: {Maas}");
		}
	}
}
