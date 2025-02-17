using Patikaflex.Abstract;
using Patikaflex.Concrete;
using System;

public class Program
{
	static void Main(string[] args)

	{
	

		List<TvSeries> tvSeries= new List<TvSeries>()
		{
			new Comedy("Avrupa Yakası",2004,2004,"Yüksel Aksu","Kanal D"),
			new Comedy("Yalan Dünya",2012,2012,"Gülseren Buda Başkaya","Fox Tv"),
			new Comedy("Jet Sosyete",2018,2018,"Gülseren Buda Başkaya","TV8"),
			new Comedy("Dadı",2006,2006,"Yusuf Pirhasan","Kanal D"),
			new Comedy("Belalı Baldız",2007,2007,"Yüksel Aksu","Kanal D"),
			new DetectiveDram("Arka Sokaklar",2004,2004,"Orhan Oğuz","Kanal D"),
			new DramRomantic("Aşkı-Memnu",2008,2008,"Hilal Saral","Kanal D"),
			new HistoryDram("Muhteşem Yüzyıl",2011,2011,"Mercan Çilingiroğlu","Star Tv"),
			new Dram("Yaprak Dökümü",2006,2006,"Serdar Aka","Kanal D")

		};

		var comedies = tvSeries.Where(x => x.Genre == "Comedy");

		foreach (var comedy in comedies)
		{
			Console.WriteLine($"{comedy.Name }  komedi türünde bir dizi ve yapımcısı {comedy.Director}'dir.");
		}

		var allTvSeries = tvSeries.OrderBy(x => x.Name)
								  .ThenBy(x => x.Director);

		foreach (var series in allTvSeries )
		{
			series.InfoTvSeries();
			
		}


	}
}
