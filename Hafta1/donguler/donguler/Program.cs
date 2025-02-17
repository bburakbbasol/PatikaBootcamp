// İlk döngü: 10 kez "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırır.
for (int i = 0; i < 10; i++)
{
	Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

// İkinci döngü: 1'den 20'ye kadar (20 dahil değil) tüm sayıları yazdırır.
for (int i = 1; i < 21; i++)
{
	Console.WriteLine($"{i}");
}

// Üçüncü döngü: 2'den başlayarak 20'ye kadar olan çift sayıları yazdırır.
for (int i = 2; i < 21; i += 2)
{
	Console.WriteLine($"{i}");
}

// Dördüncü döngü: 50 ile 150 arasındaki sayıların toplamını hesaplar.
int toplam = 0;
for (int i = 50; i < 151; i++)
{
	toplam = toplam + i; // toplam değişkenine i'nin değerini ekler.
}
Console.WriteLine($"{toplam}"); // Toplam sonucu ekrana yazdırılır.

// Beşinci döngü: 0 ile 120 arasındaki çift ve tek sayıların toplamını hesaplar.
int tek = 0; // Tek sayıların toplamını tutar.
int cift = 0; // Çift sayıların toplamını tutar.

for (int i = 0; i < 121; i++)
{
	if (i % 2 == 0) // Eğer sayı 2'ye tam bölünüyorsa, çift sayıdır.
	{
		cift = cift + i; // Çift sayı toplamına eklenir.
	}
	else // Aksi halde tek sayıdır.
	{
		tek = tek + i; // Tek sayı toplamına eklenir.
	}
}

// Tek ve çift sayıların toplamını ekrana yazdırır.
Console.WriteLine($"Tek Sayıların Toplamı= {tek}\nÇift Sayıların Toplamı= {cift}");
