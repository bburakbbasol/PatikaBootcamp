
using System.Collections.Concurrent;
Console.Write("Lütfen Sayı Giriniz:");
string strnum = Console.ReadLine();

int num = Convert.ToInt32(strnum);

if ( num > 10)
{
	if(num%2==0)
	{
		Console.WriteLine("Girelen Sayı Çiftdir");
	}
	else
	{
		Console.WriteLine("Girilen Sayı Tekdir");
	}
}
else 
{

	Console.WriteLine("Girilen Sayı 10 dan küçüktür");
}
