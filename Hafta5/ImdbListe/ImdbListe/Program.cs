using ImdbListe;
using System;
using System.Collections.Generic;
//ImdFilm Clas'ın da bir liste
List<ImdbFilm> filmler = new List<ImdbFilm>();

//Kullanıcıdan Alacağımız Sonsunsuz Film Döngüsü
while (true)
{
	
	Console.Write("Film ismini giriniz: ");
	//ImdbFilm clas'ın da türedilmiş film nesnesi
	ImdbFilm film = new ImdbFilm();
	//Kullanıcıdan alınan film isimi
	film.FilmIsmi = Console.ReadLine();
	Console.Write("Imdb Puanına Giriniz: ");
	film.ImdbPuani=Convert.ToDouble(Console.ReadLine());
	// Film listesine ekleniyor.
	filmler.Add(film);
// Kullanıcıya başka bir film eklemek isteyip istemediği soruluyor.
sorgu: Console.Write("Başka bir Film Girmek istiyormusnuz(evet/hayır): ");
	string cevap=Console.ReadLine();
	if (cevap.ToLower() == "evet")
	{
		continue; // Döngü başa döner.
	}
	else if (cevap.ToLower() == "hayır")

	{
		Console.WriteLine("Filmler listeye kayıt ediliyor...");
		break;// Döngü sonlanır.
	}
	else
	{
		Console.WriteLine(cevap+" ifade geçersiz bir ifade (evet/hayır) şeklinde giriş yapın lütfen6");
		goto sorgu; // Geçersiz girişte yeniden giriş isteği.
	}
	

}
// Filmler listesi sıralanıyor (varsayılan küçükten büyüğe).
filmler.Sort((x, y) => x.ImdbPuani.CompareTo(y.ImdbPuani));
// Liste ters çevrilerek büyükten küçüğe sıralanıyor.
filmler.Reverse();
foreach (var film in filmler)
{
	Console.WriteLine("Filmimizin ismi: "+film.FilmIsmi+" ve fimin IMDB puanı= "+film.ImdbPuani);

	
}
foreach (var film in filmler)

{// IMDb puanı 4 ile 9 arasında olan filmler listelemesi.
	if (film.ImdbPuani >= 4 && film.ImdbPuani <= 9)
	{

		Console.WriteLine("IMDB puanı 4 ile 9 arasında olan filmler");
		Console.WriteLine("Filmimizin ismi: " + film.FilmIsmi + " ve fimin IMDB puanı= " + film.ImdbPuani);

	}
}
// İsmi 'A' harfi ile başlayan filmleri listeleme.
var aHarfiBaslayanFilm =filmler.Where(f=>f.FilmIsmi.StartsWith("A")).ToList();

foreach(var film in aHarfiBaslayanFilm)
{
	Console.WriteLine("A harfi ile başlayan filmler ");
	Console.WriteLine(film);
}
