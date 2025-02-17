//using System;
//class Program
//{
//	static void Main()
//	{
//		Song();
//	}
//	static void Song()
//	{
//		Console.WriteLine("İlk gençliğimde\nYeni uzamış saçım ve\nGüneş gözlüğüm");
//		Console.WriteLine("          ");
//		Console.WriteLine("Nası' kendini beğenmiş\r\nAğzımdan küfür eksilmezmiş\r\nAma güzel gözlüğüm");
//	}
//}

//using System;
//class Program
//{
//	static void Main()
//	{
//		Random random = new Random();
//		int randomNumber = random.Next();// 0 ile maxdeğer arasında sayı üretir.
//		int resault = Solution(randomNumber);
//		Console.WriteLine(" Rastgele üretilen sayı: "+randomNumber+" rastgele üretilen sayıdan kalan "+resault);

//	}static int Solution(int a)
//	{

//		return a%2 ;


//	}
//}


//using System;
//class Program
//{
//	static void Main()
//	{
//		int resault = AddNumber(6, 5);
//		Console.WriteLine(" Sonuc : "+resault);

//	}
//	static int AddNumber(int a, int b)
//	{
//		return a * b;
//	}
//}

using System;
class Program
{
	static void Main()
	{
		User("Burak","Başol");
		

	}
	static void User(string name,string surname)
	{
		Console.WriteLine($"Hoş Geldiz {name} {surname}");
	}
}