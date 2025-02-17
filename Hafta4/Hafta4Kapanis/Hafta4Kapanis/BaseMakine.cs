namespace Hafta4Kapanis
{
	// Genel bir makineyi temsil eden soyut sınıf
	public abstract class BaseMakine
	{
		// Üretim tarihi, mevcut zaman olarak ayarlanır
		public DateTime UretimTarihi = DateTime.Now;

		// Makinenin seri numarası
		public string SeriNumarası { get; set; }

		// Makinenin adı
		public string Ad { get; set; }

		// Makinenin açıklaması
		public string Aciklama { get; set; }

		// Makinenin işletim sistemi
		public string IsletimSistemi { get; set; }

		// Makine bilgilerini yazdıran soyut metot
		public abstract void BilgileriYazdır();

		// Ürünün adını getiren soyut metot
		public abstract void UrunAdiGetir();
	}
}
