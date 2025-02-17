using System;

namespace PratikAbstraction
{
	// Temel soyut Personel sınıfı
	public abstract class Personel
	{
		private string _ad;
		private string _soyad;
		private string _gorevi;

		// Ad özelliği
		public string Ad
		{
			get { return _ad; }
			set { _ad = value; }
		}

		// Soyad özelliği
		public string Soyad
		{
			get { return _soyad; }
			set { _soyad = value; }
		}

		// Görevi özelliği
		public string Gorevi
		{
			get { return _gorevi; }
			set { _gorevi = value; }
		}

		// Soyut metot, türetilen sınıflarda uygulanır
		public abstract void Gorev();
	}

	// Yazılım Geliştirici sınıfı
	public class YazılımGelistirici : Personel
	{
		public YazılımGelistirici(string ad, string soyad)
		{
			Ad = ad;
			Soyad = soyad;
		}

		// Yazılım Geliştirici için görev tanımı
		public override void Gorev()
		{
			Console.WriteLine($"{Ad} {Soyad} Yazılım Geliştirici");
		}
	}

	// Proje Yöneticisi sınıfı
	public class ProjeYoneticisi : Personel
	{
		public ProjeYoneticisi(string ad, string soyad)
		{
			Ad = ad;
			Soyad = soyad;
		}

		// Proje Yöneticisi için görev tanımı
		public override void Gorev()
		{
			Console.WriteLine($"{Ad} {Soyad} Proje Yöneticisi");
		}
	}

	// Satış Temsilcisi sınıfı
	public class SatısTemsilcisi : Personel
	{
		public SatısTemsilcisi(string ad, string soyad)
		{
			Ad = ad;
			Soyad = soyad;
		}

		// Satış Temsilcisi için görev tanımı
		public override void Gorev()
		{
			Console.WriteLine($"{Ad} {Soyad} Satış Temsilcisi");
		}
	}
}
