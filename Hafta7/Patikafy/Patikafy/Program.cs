using Patikafy;
using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

public class Program
{

	static void Main(string[] args)
	{


	List<Sanatci> sanantcilar = new List<Sanatci>()
	{
			new Sanatci("Ajda Pekkan", 20, 1968, "Pop"),
			new Sanatci("Sezen Aksu", 10, 1971, "Türk Halk Müziği/Pop"),
			new Sanatci("Funda Arar", 3, 1999, "Pop"),
			new Sanatci("Sertap Erener", 5, 1994, "Pop"),
			new Sanatci("Sıla", 3, 2009, "Pop"),
			new Sanatci("Serdar Ortaç", 10, 1994, "Pop"),
			new Sanatci("Tarkan", 40, 1992, "Pop"),
			new Sanatci("Hande Yener", 7, 1999, "Pop"),
			new Sanatci("Hadise", 5, 2005, "Pop"),
			new Sanatci("Gülben Ergen", 10, 1997, "Pop/Türk Halk Müziği"),
			new Sanatci("Neşet Ertaş", 2, 1960, "Türk Halk Müziği/Türk Sanat Müziği")

	};

		//Adı S ile başlayanlar

		var sHarf=sanantcilar.Where(k=>k.AdSoyad.StartsWith("S")).ToList();
		
		foreach(var s in sHarf)
		{
			Console.WriteLine(s.AdSoyad);
		}

		//Satış 10 milyon üstü olan sanatcılar.
		Console.WriteLine("-----------------------");
		Console.WriteLine("-----------------------");

		var satis = sanantcilar.Where(k => k.Satis > 10);

		foreach (var s in satis)
		{
			Console.WriteLine(s.AdSoyad);
		}

		Console.WriteLine("-----------------------");
		Console.WriteLine("-----------------------");

		// 2000'den önce çıkış yapmış ve pop müzüik yapan şarkıcılar.

		var grupSanatci = sanantcilar.Where(x => x.CikisYıl < 2000 && x.Tur == "Pop")
									  .GroupBy(s => s.CikisYıl)
									  .OrderBy(x => x.Key);
		foreach(var grup in grupSanatci)
		{
			Console.WriteLine($"{grup.Key}  yılında çıkış yapan sanatçılar");
			foreach(var sarkici in grup)
			{
				Console.WriteLine($"{sarkici.AdSoyad}");
			}
		}
		Console.WriteLine("-----------------------");
		Console.WriteLine("-----------------------");

		// En çok Albüm satan sanatçı

		var enFazlaSatan = sanantcilar.OrderByDescending(x => x.Satis).First();
		Console.WriteLine("En fazla albüm satan sanatcı: "+enFazlaSatan.AdSoyad);


		// En yeni çıkış yapan ve en eski çıkış yapan sanatçı 

		var enYeniCikis = sanantcilar.OrderByDescending(x => x.CikisYıl).First();
		var enEskiCikis = sanantcilar.OrderByDescending(x => x.CikisYıl).Last();

		Console.WriteLine($"{enYeniCikis.AdSoyad } en yeni çıkış yapan sanatçı, en eski çıkış yapan ise {enEskiCikis.AdSoyad}");

									
	}


}
