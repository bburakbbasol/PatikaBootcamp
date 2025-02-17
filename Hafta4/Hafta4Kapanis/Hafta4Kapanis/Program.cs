using Hafta4Kapanis;

// Program durumunu kontrol eden değişken
bool programDurumu = true;

// Program sonsuz döngü içinde çalışır
while (programDurumu == true)
{
	// Kullanıcıdan bilgisayar veya telefon üretme seçimi istenir
	Console.Write("Bilgisayar üretmek için 1, Telefon üretmek için 2'ye basınız: ");
	int secim = Convert.ToInt32(Console.ReadLine());

	if (secim == 1)
	{
		// Bilgisayar bilgilerini almak için gerekli değişkenler tanımlanır
		string serino;
		string ad;
		string acıkla;
		string isletim;
		int usbSayisi;

		// Kullanıcıdan bilgisayar için gerekli bilgiler alınır
		Console.Write("Seri No giriniz: ");
		serino = Console.ReadLine();
		Console.Write("Bilgisayar adını giriniz: ");
		ad = Console.ReadLine();
		Console.Write("Açıklama: ");
		acıkla = Console.ReadLine();
		Console.Write("İşletim sistemini giriniz: ");
		isletim = Console.ReadLine();
		Console.Write("USB sayısını giriniz (2 veya 4 olacak şekilde): ");
		usbSayisi = Convert.ToInt32(Console.ReadLine());

		// Yeni bir Bilgisayar nesnesi oluşturulur ve bilgiler yazdırılır
		BaseMakine yeniBilgisayar = new Bilgisayar(serino, ad, acıkla, isletim, usbSayisi);
		yeniBilgisayar.BilgileriYazdır();
		yeniBilgisayar.UrunAdiGetir();
	}
	else if (secim == 2)
	{
		// Telefon bilgilerini almak için gerekli değişkenler tanımlanır
		string serino;
		string ad;
		string acıkla;
		string isletim;
		string trLisans;

		// Kullanıcıdan telefon için gerekli bilgiler alınır
		Console.Write("Seri No giriniz: ");
		serino = Console.ReadLine();
		Console.Write("Telefon adını giriniz: ");
		ad = Console.ReadLine();
		Console.Write("Açıklama: ");
		acıkla = Console.ReadLine();
		Console.Write("İşletim sistemini giriniz: ");
		isletim = Console.ReadLine();
		Console.Write("TR Lisansını giriniz: ");
		trLisans = Console.ReadLine();

		// Yeni bir Telefon nesnesi oluşturulur ve bilgiler yazdırılır
		BaseMakine yeniTelefon = new Telefon(serino, ad, acıkla, isletim, trLisans);
		yeniTelefon.BilgileriYazdır();
		yeniTelefon.UrunAdiGetir();
	}
	else
	{
		// Geçersiz bir seçim yapıldığında kullanıcıya uyarı verilir
		Console.WriteLine("Lütfen geçerli bir değer giriniz.");
	}

	// Kullanıcıya başka bir değer üretmek isteyip istemediği sorulur
	Console.WriteLine("Başka bir değer üretmek istiyor musunuz? (evet veya hayır şeklinde cevaplayın)");
	string cevap = Console.ReadLine();

	if (cevap.ToLower() == "evet")
	{
		// Kullanıcı "evet" derse program devam eder
		programDurumu = true;
	}
	else if (cevap.ToLower() == "hayır")
	{
		// Kullanıcı "hayır" derse program sona erer
		programDurumu = false;
	}
	else
	{
		// Geçersiz bir cevap verildiğinde uyarı mesajı gösterilir
		Console.WriteLine("Başka bir değer üretmek için geçerli bir cevap girmediniz.");
	}
}
