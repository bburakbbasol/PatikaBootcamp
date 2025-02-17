using System;
//10 adet tam sayı alacak dizi tanımı
Console.WriteLine("10 adet tam sayı verisi girişi yaparmısınız: ");
//Kullanıcıdan diziler alındı
int[] sayilar = new int[10];
for (int i = 0;i < 10; i++)
{
	//a değeri kaçıncı eleman olduğu gösterdi
	int a = i + 1;
	Console.Write(a + " elamanı giriniz: ");
	sayilar[i] =Convert.ToInt32(Console.ReadLine());
}
//Sayılar ekrana bastırıldı
foreach(int sayi in sayilar)
{
	Console.WriteLine(sayi);
	
}
//11 eleman eklendi
Console.Write("11. değeri giriniz: ");
int sondeger = Convert.ToInt32(Console.ReadLine());

Array.Resize(ref sayilar,sayilar.Length+1);
//11 eleman atama yapıldı
sayilar[sayilar.Length-1] = sondeger;


//Küçükten büyüğe sıralama
Array.Sort(sayilar);
//Ters çevirip büyükten küçüğe sıralama
Array.Reverse(sayilar);
//Diziyi ekrana bastırma
for (int i = 0; i < sayilar.Length; i++)
{
	Console.WriteLine(sayilar[i]);
}