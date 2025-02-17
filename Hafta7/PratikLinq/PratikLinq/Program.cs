using System;

public class Program
{
	static void Main(string[] args)
	{
		List<int> numbers = new List<int>() { -5, -10, -34, -45, 44, 32, 12, 22, 18, 25 };
		Console.WriteLine("Çift sayılar");
		Console.WriteLine("");

		var evenNumbers = numbers.Where(n => n % 2 == 0);
		foreach (int n in evenNumbers)
		{
			
			Console.WriteLine(n);
		}

		IEnumerable<int> oddNumber = numbers.Where(n => n % 2 == 1 || n % 2 == -1);
		Console.WriteLine("Tek Sayılar");
		Console.WriteLine("");
		foreach (int n in oddNumber)
		{
			Console.WriteLine(n);

		}
		Console.WriteLine("");
		Console.WriteLine("Negatif  Sayılar");
		Console.WriteLine("");
		var negativeNumber = numbers.Where(n => n < 0);

		foreach (int n in negativeNumber)
		{
			Console.WriteLine(n);
		}
		Console.WriteLine("");
		Console.WriteLine("Pozitif  Sayılar");
		Console.WriteLine("");

		IEnumerable<int> positveNumber = numbers.Where(n => n > 0);
		foreach (var n in positveNumber)
		{
			Console.WriteLine(n);

		}
		Console.WriteLine("");
		Console.WriteLine("15 ile 22 arasındaki sayılar");
		Console.WriteLine("");

		var rangeNumber = numbers.Where(n => n > 15 && n < 22);
		foreach (var n in rangeNumber)
		{
			Console.WriteLine(n);

		}
		Console.WriteLine("");
		Console.WriteLine("Sayıların Karesi");
		Console.WriteLine("");

		var squareNumber = numbers.Select(n => n * n);
		foreach (var n in squareNumber)
		{
			Console.WriteLine(n);
		}




	}
}