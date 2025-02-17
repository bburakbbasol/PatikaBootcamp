using System;
using System.Collections.Specialized;
using System.Data;
using System.Threading.Channels;
class Program
{
	static void Main()
	{
		Console.WriteLine("--------------------Örnek1-------------------------------------");
		Console.WriteLine("Merhaba\nNasılsın ?\nİyiyim\nSen Nasılsın");

		Console.WriteLine("--------------------Örnek2--------------------------------------");

		int sayi1 = 99;
		string metin = "Ajda Pekkan";

		Console.WriteLine("Sayısal Değer: " + sayi1);
		Console.WriteLine($"Metinsel Değer: {metin}");


		Console.WriteLine("--------------------Örnek3--------------------------------------");


		Random random = new Random();
		int randomsayi = random.Next(1, 99999);
		Console.WriteLine("Rastgele Sayi " + randomsayi);



		Console.WriteLine("--------------------Örnek4-------------------------------------");

		int kalan = randomsayi % 3;
		Console.WriteLine("Random üretilen sayının 3 ile bölümünden Kalan: " + kalan);


		Console.WriteLine("--------------------Örnek5--------------------------------------");

		Console.Write("Kaç Yaşindasınız: ");
		int yas = Convert.ToInt32(Console.ReadLine());

		if (yas > 18)
			Console.WriteLine("+");
		else
			Console.WriteLine("-");


		Console.WriteLine("--------------------Örnek6--------------------------------------");

		for (int i = 0; i < 10; i++)
		{
			Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem");
		}


		Console.WriteLine("--------------------Örnek7--------------------------------------");


		Console.WriteLine("Sırasıyla Gülse Bİrsel ve Demet Evgar Giriniz");
		string deger1 = Console.ReadLine();
		string deger2 = Console.ReadLine();
		string temp = deger1;
		deger1 = deger2;
		deger2 = temp;
		Console.WriteLine($"ilk girdiğiniz değer: {deger1} ikinci girdiğiniz değer: {deger2}");



		Console.WriteLine("--------------------Örnek8--------------------------------------");


		static void BenDegerDondurmem()
		{
			Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
		}

		BenDegerDondurmem();

		Console.WriteLine("--------------------Örnek9--------------------------------------");
		Console.WriteLine("");




		static int Toplam(int a, int b)
		{
			return a + b;
		}

		int toplam = Toplam(3, 5);
		Console.WriteLine("Değerlerin toplamı " + toplam);

		Console.WriteLine("--------------------Örnek10--------------------------------------");

		Console.WriteLine("Lütfen true Yada false Değer Giriniz :");
		bool KullanıcıGirdisi;

		while (!bool.TryParse(Console.ReadLine(), out KullanıcıGirdisi))//Aldığımız Değeri Dönüştürmemizi sağlar ve yanlış ifadeyi düzeltmemizi söyler
		{
			Console.WriteLine("Hatalı Giriş Yaptınız Lütfen true Yada false Değeri Giriniz");

		}
		string ifade = TrueFalseYorum(KullanıcıGirdisi);
		Console.WriteLine("Sonuc " + ifade);

		static string TrueFalseYorum(bool deger)
		{

			//Strin değer Döndürür
			if (deger == true)
			{
				return "Kullanıcı true değeri girdi";
			}
			else
			{
				return "Kullanıcı false değeri girdi";
			}
		}



		Console.WriteLine("--------------------Örnek11--------------------------------------");
		Console.WriteLine("");
		int enyaslı = EnYaslıBul(8, 88, 45);
		Console.WriteLine("En yaşlı Kişi: " + enyaslı);

		static int EnYaslıBul(int kisi1, int kisi2, int kisi3)
		{
			int[] kisiler = new int[3];
			kisiler[0] = kisi1;
			kisiler[1] = kisi2;
			kisiler[2] = kisi3;
			Array.Sort(kisiler);

			return kisiler[2];
		}

		Console.WriteLine("--------------------Örnek12--------------------------------------");
		Console.WriteLine("");

		int sum = EnBuyuk();
		Console.WriteLine("Girdiğiniz En Büyük Değer: " + sum);

		static int EnBuyuk()
		{
			int[] sayilar = new int[0];
			while (true)
			{
				Console.WriteLine("Eklemek İstediğiniz Sayıyı Giriniz ");
				int sayi = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Sayı eklemek istemiyorsanız h yazmanız yeterlidir.");
				string cikis = Console.ReadLine();

				Array.Resize(ref sayilar, sayilar.Length + 1);// Dizinin boyutunun 1 artırıyor 
				sayilar[sayilar.Length - 1] = sayi;//Kullanıcıdan aldığımız sayi değişkenini sayilar dizisini aktarıyoruz

				if (cikis == "h")
					break;


			}
			Array.Sort(sayilar);
			int enbuyuk = sayilar[sayilar.Length - 1];//Dizedeki en son eleman en büyük olacağı için en büyük değeri akdık 1 çıkarmamızın sebebi diziler 0 dan başlaması 
			return enbuyuk;

		}



		Console.WriteLine("--------------------Örnek13--------------------------------------");
		Console.WriteLine("");

		Console.WriteLine("Birinci ismi giriniz:");
		string isim1 = Console.ReadLine();
		Console.WriteLine("ikinci ismi giriniz:");
		string isim2 = Console.ReadLine();
		YerDegistir(ref isim1, ref isim2);

		// Sonuçları ekrana yazdır
		Console.WriteLine("Yer değiştirildikten sonra:");
		Console.WriteLine("Birinci isim: " + isim1);
		Console.WriteLine("İkinci isim: " + isim2);

		static void YerDegistir(ref string isim1, ref string isim2)
		{
			// Geçici bir değişken kullanarak yer değiştir
			string temp = isim1;
			isim1 = isim2;
			isim2 = temp;
		}


		Console.WriteLine("--------------------Örnek14--------------------------------------");
		Console.WriteLine("");

		Console.WriteLine("Lütfen Bir Sayı Giriniz: ");
		int ksayi=Convert.ToInt32(Console.ReadLine());
		bool cevap=TekCift(ksayi);
		Console.WriteLine(" "+cevap);



	static bool TekCift(int ksayi)
	{
		if (ksayi % 2 == 0)
			return true;

		else
			return false;
	}



		Console.WriteLine("--------------------Örnek15--------------------------------------");
		Console.WriteLine("");


		Console.Write("Hızınızı Griniz km/saat cinsinden : ");
		int hız=Convert.ToInt32(Console.ReadLine());
		Console.Write("Geçen Süreyi Giriniz saat cinsinden: ");
		int zaman=Convert.ToInt32(Console.ReadLine());

		
		int yol=Yol(hız,zaman);
		Console.WriteLine("");

		static int Yol(int hız,int zaman)
		{
			return hız * zaman;
		}

		Console.WriteLine("--------------------Örnek16--------------------------------------");
		Console.WriteLine("");

		YariCapDaire(45);


		static double YariCapDaire(int alan)
		{

			return 3.14 * (alan ^ 2);
		}

		Console.WriteLine("--------------------Örnek17--------------------------------------");
		Console.WriteLine("");

		string gerisay = "Zaman bir GeRi SayIm";
		string kgerisay=gerisay.ToLower();
		Console.WriteLine(kgerisay);
		string bgerisay=gerisay.ToUpper();
		Console.WriteLine(bgerisay);

		Console.WriteLine("--------------------Örnek1--------------------------------------");
		Console.WriteLine("");

		string metinn = "    Selamlar   ";
		metin = metinn.Trim();
		Console.WriteLine(metinn);

	}


}





