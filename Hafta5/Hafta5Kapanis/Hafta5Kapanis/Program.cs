using Hafta5Kapanis;

using System;
using System.Collections.Generic;

class program
{
	static void Main(string[] args)
	{
		// Araba nesnelerini tutmak için bir liste oluşturuluyor
		List<Araba> arabalar = new List<Araba>();

		while (true)
		{
			// Kullanıcıdan araba üretmek isteyip istemediğini sorar
			Console.Write("Araba üretmek istiyor musunuz (e/h) şeklinde giriş yapmanız yeterli: ");
			string cevap = Console.ReadLine();

			if (cevap.ToLower() == "e")
			{
				// Yeni bir araba nesnesi oluşturuluyor
				Araba arabam = new Araba();

				// Kullanıcıdan arabanın detaylarını alır
				Console.WriteLine("Arabanın seri numarasını giriniz: ");
				arabam.seriNo = Console.ReadLine();

				Console.WriteLine("Arabanın markasını giriniz: ");
				arabam.marka = Console.ReadLine();

				Console.WriteLine("Arabanın modelini giriniz: ");
				arabam.model = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Arabanın rengini giriniz: ");
				arabam.renk = Console.ReadLine();

			kapi:
				try
				{
					// Kullanıcıdan kapı sayısını alır
					Console.WriteLine("Arabanın Kapı Sayısını Giriniz:");
					arabam.kapiSayisi = Convert.ToInt32(Console.ReadLine());
				}
				catch (FormatException)
				{
					// Hatalı girişlerde kullanıcıyı uyarır ve tekrar giriş yaptırır
					Console.WriteLine("Lütfen sayı şeklinde giriniz:");
					goto kapi;
				}
				catch (OverflowException)
				{
					// Çok yüksek veya düşük değerler girildiğinde kullanıcıyı uyarır
					Console.WriteLine("Çok yüksek veya çok düşük bir değer girdiniz");
					goto kapi;
				}

				// Araba nesnesi listeye eklenir
				arabalar.Add(arabam);
				Console.WriteLine("Araba listeye eklenmiştir..");
			}
			else if (cevap.ToLower() == "h")
			{
				// Kullanıcı hayır cevabı verirse, listede bulunan tüm arabaların marka ve model yazdırır
				foreach (var araba in arabalar)
				{
					Console.WriteLine($"{araba.marka} markalı araç seri numarası: {araba.seriNo}");
				}

				// Döngüden çıkılır
				break;
			}
			else
			{
				// Geçersiz girişlerde kullanıcıyı uyarır
				Console.WriteLine("Lütfen geçerli bir değer giriniz...");
			}
		}
	}
}