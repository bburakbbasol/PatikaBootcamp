// BaseMakine sınıfından türetilen Bilgisayar sınıfı
namespace Hafta4Kapanis
{
	public class Bilgisayar : BaseMakine
	{
		// USB port sayısı için özel alan
		private int _usbSayi;

		// USB port sayısını tutan ve doğrulayan özellik
		public int UsbSayisi
		{
			get
			{
				return _usbSayi;
			}
			set
			{
				// USB port sayısını doğrulama (sadece 2 veya 4 kabul edilir)
				if (!(value == 2 || value == 4))
				{
					_usbSayi = -1;
				}
				else
				{
					_usbSayi = value;
				}
			}
		}

		// Bilgisayarın özelliklerini başlatan yapıcı metot
		public Bilgisayar(string serino, string ad, string acıkla, string isletim, int usbSayisi)
		{
			Ad = ad;
			SeriNumarası = serino;
			Aciklama = acıkla;
			IsletimSistemi = isletim;
			UsbSayisi = usbSayisi;
		}

		// Bilgisayar bilgilerini yazdıran metot (override)
		public override void BilgileriYazdır()
		{
			Console.WriteLine($"{UretimTarihi} tarihinde üretilmiş seri numarası {SeriNumarası}, {Ad}, {Aciklama}, usb sayısı {UsbSayisi}, {IsletimSistemi} bilgisayar.");
		}

		// Bilgisayar adını getiren metot (override)
		public override void UrunAdiGetir()
		{
			Console.WriteLine("Bilgisayar adı ----------> " + Ad);
		}
	}
}