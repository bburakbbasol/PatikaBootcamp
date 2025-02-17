// 1'den 10'a kadar olan sayılar için döngü çalıştırılır.
// Her adımda "Kendime inanıyorum, ben bu yazılım işini hallederim!" mesajı yazdırılır.
int i = 1;
while (i < 11)
{
	Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
	i++; // Döngü değişkeni bir artırılır.
}

// 1'den 20'ye kadar olan sayılar sırayla yazdırılır.
int a = 1;
while (a <= 20)
{
	Console.WriteLine("" + a);
	a++; // Döngü değişkeni bir artırılır.
}

// 2'den başlayarak 20'ye kadar olan çift sayılar yazdırılır.
int c = 2;
while (c <= 20)
{
	Console.WriteLine(" " + c);
	c += 2; // Döngü değişkeni her adımda 2 artırılır.
}

// 50 ile 150 arasındaki sayıların toplamı hesaplanır.
int d = 50;
int toplam = 0;
while (d <= 150)
{
	toplam = toplam + d; // Toplam değişkenine d'nin değeri eklenir.
	d++; // Döngü değişkeni bir artırılır.
}
Console.WriteLine(" " + toplam); // Hesaplanan toplam yazdırılır.

// 1 ile 120 arasındaki sayıların tek ve çift toplamları ayrı ayrı hesaplanır.
int sayac = 1;
int tek = 0; // Tek sayıların toplamını tutar.
int cift = 0; // Çift sayıların toplamını tutar.
while (sayac <= 120)
{
	if (sayac % 2 == 0) // Sayı çift mi kontrol edilir.
	{
		cift = cift + sayac; // Çift sayı toplamına eklenir.
	}
	else // Aksi halde sayı tektir.
	{
		tek = tek + sayac; // Tek sayı toplamına eklenir.
	}
	sayac++; // Döngü değişkeni bir artırılır.
}

// Toplam sonuçları yazdırılır.
Console.WriteLine("1 ile 120 arasındaki tek sayıların toplam: " + tek);
Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + cift);
