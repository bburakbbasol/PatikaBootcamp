// "Kim Milyoner Olmak İster" oyunu
using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Kim Milyoner Olmak İstere Hoş Geldiniz\nSadece harf yazmanız Gerek!!!!!!!!!!!!!!!!\n");

		int correctAnswers = 0;

		// Soru 1
		Console.WriteLine("Kızınca Tüküren Hayvan Hangisi");
		Console.Write("A) Lama \nB) Deve\nCevap Giriniz: ");
		string answer1 = Console.ReadLine()?.ToLower();

		if (answer1 == "a")
		{
			Console.WriteLine("Cevabınız Doğrudur\n");
			correctAnswers++;
		}
		else if (answer1 == "b")
		{
			Console.WriteLine("Yanlış Cevap. Büyük ödül için önümüzdeki 2 soruyu doğru cevaplayınız\n");
		}
		else
		{
			Console.WriteLine("Lütfen Geçerli cevap Giriniz\n");
		}

		// Soru 2
		Console.WriteLine("Dünyaya En Yakın Gezegen Hangisidir");
		Console.Write("A) Mars \nB) Venüs\nCevap Giriniz: ");
		string answer2 = Console.ReadLine()?.ToLower();

		if (answer2 == "b")
		{
			Console.WriteLine("Cevabınız Doğrudur\n");
			correctAnswers++;
		}
		else if (answer2 == "a")
		{
			Console.WriteLine("Yanlış Cevap. Büyük ödül için önümüzdeki 2 soruyu doğru cevaplayınız\n");
		}
		else
		{
			Console.WriteLine("Lütfen Geçerli cevap Giriniz\n");
		}

		// Sonuç Değerlendirmesi
		if (correctAnswers == 2)
		{
			Console.WriteLine("Büyük ödülü kazandınız! Tebrikler!\n");
		}
		else if (correctAnswers == 1)
		{
			Console.WriteLine("Önümüzdeki soruyu doğru bilmeniz takdirde büyük ödülü kazanabilirsiniz\n");

			// Soru 3
			Console.Write("5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?\nA) 12 \nB) 15\nCevabı Giriniz: ");
			string answer3 = Console.ReadLine()?.ToLower();

			if (answer3 == "a")
			{
				Console.WriteLine("Büyük Ödülü Kazandınız! Tebrikler!\n");
			}
			else
			{
				Console.WriteLine("Malesef Kaybettiniz :(\n");
			}
		}
		else
		{
			Console.WriteLine("Malesef Yarışmayı Kaybettiniz :(\n");
		}
	}
}
