using System;

namespace PatikaKutupahane
{
	public class Kitaplik
	{
		// Properties
		private string _ad;
		private string _yazarAdi;
		private string _yazarSoyadi;
		private int _sayfaSayisi;
		private string _yayinEvi;
		private DateTime _kayit;

		public string Ad
		{
			get { return _ad; }
			set { _ad = value; }
		}

		public string YazarAdi
		{
			get { return _yazarAdi; }
			set { _yazarAdi = value; }
		}

		public string YazarSoyadi
		{
			get { return _yazarSoyadi; }
			set { _yazarSoyadi = value; }
		}

		public int SayfaSayisi
		{
			get { return _sayfaSayisi; }
			set { _sayfaSayisi = value; }
		}

		public string YayinEvi
		{
			get { return _yayinEvi; }
			set { _yayinEvi = value; }
		}

		public DateTime Kayit
		{
			get { return _kayit; }
			set { _kayit = value; }
		}
		// Default constructor (parametre almayan)
		public Kitaplik()
		{
			_kayit= DateTime.Now;

		}
		//Methot
		public void KitapBilgi()
		{
			Console.WriteLine($"Kitabın adı {_ad} kitapın yazarı {_yazarAdi} {YazarSoyadi} kitabin sayfa sayisi: {SayfaSayisi}, kitabin yayin evi:{_yayinEvi},kitabın kayit tarihi:{_kayit}");
		}
		public static void KitaplikBilgi()
		{


		}

		//Parametre alan Constructor
		public Kitaplik(string ad, string yazarAdi, string yazarSoyadi, int sayfaSayisi, string yayinEvi)
		{
			_ad = ad;
			_yazarAdi = yazarAdi;
			_yazarSoyadi = yazarSoyadi;
			_sayfaSayisi = sayfaSayisi;
			_yayinEvi = yayinEvi;
			_kayit = DateTime.Now; 
		}
	}
}
