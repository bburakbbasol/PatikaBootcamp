using System;

class Program
{
	static void Main()
	{
		// Kullanıcıdan hangi oyunu oynamak istediğini seçmesini ister
		Console.Write("\n1 - Rastgele Sayı Bulma Oyunu\r\n\r\n2 - Hesap Makinesi\r\n\r\n3 - Ortalama Hesaplama birini seçiniz \r\n\r\n--->Oynamak istedediğiniz oyun için: ");
		int.TryParse(Console.ReadLine(), out int select);

		// Rastgele Sayı Bulma Oyunu
		if (select == 1)
		{
			Random randi = new Random();
			int randomnuber = randi.Next(1, 100); // 1 ile 100 arasında rastgele bir sayı üretir
			int maxvalue = randomnuber + randi.Next(1, 7); // Maksimum değer aralığı
			int minvalue = randomnuber - randi.Next(1, 7); // Minimum değer aralığı
			Console.Write("Bir Sayı Tahmin ediniz 1 ile 100 arasında: ");

			for (int i = 5; i > 0; i--) // Kullanıcıya 5 tahmin hakkı verir
			{
				int count = i - 1; // Kalan tahmin haklarını hesaplar
				int.TryParse(Console.ReadLine(), out int guess);

				// Kullanıcının geçerli bir sayı girip girmediğini kontrol eder
				if (!(guess >= 1 && guess <= 100))
				{
					Console.WriteLine("Lütfen Geçerli Bir değer Giriniz!!!!!");
					Console.Write($"Tahmininiz Yanlış.Tahmin Etmeniz gereken Sayı {minvalue} dan yüksek {maxvalue} den düşük bir sayı. Geriye kalan tahmin hakkınız({count}): ");
					continue; // Geçersiz giriş yapılırsa döngü devam eder
				}

				// Kullanıcı doğru tahminde bulunursa tebrik mesajı gösterir ve döngüden çıkar
				if (guess == randomnuber)
				{
					Console.WriteLine(" Tebrikler Doğru Tahmin ettiniz ");
					break;
				}
				else
				{
					// Kullanıcı yanlış tahminde bulunursa bilgi verir
					Console.Write($"Tahmininiz Yanlış.Tahmin Etmeniz gereken Sayı {minvalue} yüksek {maxvalue} den düşük bir sayı. Geriye kalan tahmin hakkınız({count}): ");
				}
			}

			// Rastgele oluşturulan sayıyı gösterir
			Console.WriteLine("Random oluşan Sayı: " + randomnuber);
		}
		else if (select == 2)
		{
			// Hesap Makinesi işlemi
			Console.Write("Lütfen İlk Sayıyı Giriniz: ");
			int.TryParse(Console.ReadLine(), out int numberone); // İlk sayıyı alır
			Console.Write("Lütfen ikinci Sayıyı Giriniz: ");
			int.TryParse(Console.ReadLine(), out int numbertwo); // İkinci sayıyı alır

			// Kullanıcıdan işlem türünü alır
			Console.Write("lütfen Yapmak istediğiniz işlemi seciniz\nToplama için +\r\n\r\nÇıkarma için -\r\n\r\nÇarpma için *\r\n\r\nBölme için /\n: ");
			string operation = Console.ReadLine();

			// İşlem türünün geçerli olup olmadığını kontrol eder
			while (operation != "/" && operation != "+" && operation != "-" && operation != "*")
			{
				Console.WriteLine("Lütfen Geçerli bir işlem giriniz");
				break;
			}

			// Kullanıcının seçtiği işleme göre hesaplama yapar
			switch (operation)
			{
				case "+":
					Console.WriteLine($"Toplama işleminin sonucu: {numberone + numbertwo}");
					break;
				case "-":
					Console.WriteLine($"Çıkarma işleminin sonucu: {numberone - numbertwo}");
					break;
				case "*":
					Console.WriteLine($"Çarpma işleminin sonucu: {numberone * numbertwo}");
					break;
				case "/":
					if (numbertwo == 0) // Bölme işleminde sıfıra bölme kontrolü
					{
						Console.WriteLine("Hata: Sıfıra bölme işlemi yapılamaz.");
					}
					else
					{
						Console.WriteLine($"Bölme işleminin sonucu: {numberone / numbertwo}");
					}
					break;
			}
		}
		else if (select == 3)
		{
			// Ortalama Hesaplama işlemi
			Console.Write("Birinci Ders Notunuzu Giriniz: ");
			double.TryParse(Console.ReadLine(), out double example1);
			if (!(example1 > 0 && example1 <= 100))
			{
				Console.WriteLine("Lütfen Geçerli bir değer giriniz");
				return; // Geçersiz giriş durumunda işlemi sonlandırır
			}

			Console.Write("İkinci Ders Notunuzu Giriniz: ");
			double.TryParse(Console.ReadLine(), out double example2);
			if (!(example2 > 0 && example2 <= 100))
			{
				Console.WriteLine("Lütfen Geçerli bir değer giriniz");
				return;
			}

			Console.Write("Üçüncü Ders Notunuzu Giriniz: ");
			double.TryParse(Console.ReadLine(), out double example3);
			if (!(example3 > 0 && example3 <= 100))
			{
				Console.WriteLine("Lütfen Geçerli bir değer giriniz");
				return;
			}

			// Ortalama hesaplama ve harf notunu belirleme
			double sum = (example1 + example2 + example3) / 3;
			if (sum >= 90)
			{
				Console.WriteLine($"Ortalamanız:{sum} ve geçer harf notunuz AA dır.");
			}
			else if (sum >= 85)
			{
				Console.WriteLine($"Ortalamanız:{sum} ve geçer harf notunuz BA dır.");
			}
			else if (sum >= 80)
			{
				Console.WriteLine($"Ortalamanız:{sum} ve geçer harf notunuz BB dır.");
			}
			else if (sum >= 75)
			{
				Console.WriteLine($"Ortalamanız:{sum} ve geçer harf notunuz CB dır.");
			}
			else if (sum >= 70)
			{
				Console.WriteLine($"Ortalamanız:{sum} ve geçer harf notunuz CC dır.");
			}
			else if (sum >= 65)
			{
				Console.WriteLine($"Ortalamanız:{sum} ve geçer harf notunuz DC dır.");
			}
			else if (sum >= 60)
			{
				Console.WriteLine($"Ortalamanız:{sum} ve geçer harf notunuz DD dır.");
			}
			else if (sum >= 55)
			{
				Console.WriteLine($"Ortalamanız:{sum} ve geçer harf notunuz FD dır.");
			}
			else
			{
				Console.WriteLine($"Ortalamanız:{sum} ve geçer harf notunuz FF dır.");
			}
		}
		else
		{
			// Geçersiz seçim durumunda hata mesajı
			Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz!!!!!!!!!!!!!");
		}
	}
}
