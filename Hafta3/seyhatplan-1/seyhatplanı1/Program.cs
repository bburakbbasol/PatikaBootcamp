using System;

class Program
{
	static void Main(string[] args)
	{
		// Kullanıcı tatil planlamaya devam ettiği sürece çalışacak olan değişken
		string plan = "evet";

		// Döngü: Kullanıcı "evet" dediği sürece çalışır
		while (plan == "evet")
		{
			// Kullanıcıya seçenekleri sun ve tatil lokasyonu sor
			Console.WriteLine("Bu pratikte bir yardımcı seyahat uygulaması ile kullanıcılarımızın planlayacakları 3 günlük bir tatilde harcayacakları yaklaşık tutarı hesaplamalarına yardımcı oluyoruz.\n3 adet lokasyonumuz var:\n\n1 - Bodrum (Paket başlangıç fiyatı 4000 TL)\n\n2 - Marmaris (Paket başlangıç fiyatı 3000 TL)\n\n3 - Çeşme (Paket başlangıç fiyatı 5000 TL)");
			Console.Write("Bu üç lokasyondan birini giriniz: ");
			string location = Console.ReadLine().ToLower(); // Lokasyon girdisini küçük harfe çeviriyoruz

			// Seçilen lokasyona göre başlangıç fiyatı değişkeni
			int packagePrice = 0;

			// Kullanıcının lokasyon seçimini kontrol et
			if (location == "bodrum")
			{
				packagePrice = 4000; // Bodrum için fiyat
			}
			else if (location == "marmaris")
			{
				packagePrice = 3000; // Marmaris için fiyat
			}
			else if (location == "çeşme")
			{
				packagePrice = 5000; // Çeşme için fiyat
			}
			else
			{
				// Geçersiz giriş durumunda uyarı ve döngüye dönüş
				Console.WriteLine("Geçersiz lokasyon! Lütfen Bodrum, Marmaris veya Çeşme seçeneklerinden birini giriniz.");
				continue;
			}

			// Kullanıcıdan kaç kişi tatil planladığını sor
			Console.Write("Kaç kişi tatil planlıyorsunuz: ");
			int people = Convert.ToInt32(Console.ReadLine()); // Girdi tam sayıya çevriliyor

			// Ulaşım türü seçimi ve bilgi mesajı
			Console.WriteLine("\nTatile ne şekilde gitmek istersiniz?\n1 - Kara yolu (Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL)\n2 - Hava yolu (Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
			Console.Write("Seçiminizi 1 veya 2 şeklinde giriniz: ");
			int transport = Convert.ToInt32(Console.ReadLine()); // Kullanıcıdan ulaşım türü alınıyor

			// Ulaşım seçiminin geçerliliğini kontrol et
			if (transport != 1 && transport != 2)
			{
				// Hatalı seçim durumunda uyarı ve döngüye dönüş
				Console.WriteLine("Geçersiz seçim! Lütfen 1 veya 2 şeklinde bir değer giriniz.");
				continue;
			}

			// Ulaşım fiyatını seçime göre belirle
			if (transport == 1)
			{
				int totalPrice = (people * 1500) + packagePrice;
				Console.WriteLine($"\nBu tatil size toplam {totalPrice} TL'ye mal olacaktır.");
			}
			if (transport == 2)
			{
				int totalPrice = (people * 4000) + packagePrice;
				Console.WriteLine($"\nBu tatil size toplam {totalPrice} TL'ye mal olacaktır.");
			}

			// Başka tatil planı yapıp yapmayacağını sor
			Console.Write("Başka tatil planlıyor musunuz (evet/hayır): ");
			plan = Console.ReadLine().ToLower(); // Girdi küçük harfe çevriliyor
		}

		// Kullanıcı "hayır" dediğinde program sonlanır
		Console.WriteLine("İyi günler dileriz!");
	}
}
