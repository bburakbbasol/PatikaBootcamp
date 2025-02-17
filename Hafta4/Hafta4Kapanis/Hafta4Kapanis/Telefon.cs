// BaseMakine sınıfından türetilen Telefon sınıfı
namespace Hafta4Kapanis
{
	public class Telefon : BaseMakine
	{
		// Telefon için Türkiye lisansı
		public string TrLisans { get; set; }

		// Telefonun özelliklerini başlatan yapıcı metot
		public Telefon(string serino, string ad, string acıkla, string isletim, string trLisans)
		{
			Ad = ad;
			SeriNumarası = serino;
			Aciklama = acıkla;
			IsletimSistemi = isletim;
			TrLisans = trLisans;
		}

		// Telefon bilgilerini yazdıran metot (override)
		public override void BilgileriYazdır()
		{
			Console.WriteLine($"{UretimTarihi} tarihinde üretilmiş seri numarası {SeriNumarası}, {Ad}, {Aciklama}, {IsletimSistemi} Telefon  TrLisansı {TrLisans}");
			
		}

		// Telefon adını getiren metot (override)
		public override void UrunAdiGetir()
		{
			Console.WriteLine("Telefonunuz adı ----------> " + Ad);
		}
	}
}