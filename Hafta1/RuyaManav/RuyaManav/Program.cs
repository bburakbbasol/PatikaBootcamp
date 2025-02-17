Console.WriteLine("Ruya Manavına Hoşgeldiniz !");//Meyvelerin fiyatlarını ekrana yazdırdık
Console.WriteLine("Elma=2TL");
Console.WriteLine("Armut=3TL");
Console.WriteLine("Çilek=2TL");
Console.WriteLine("Muz=3TL");
Console.WriteLine("Diğer Bütün Meyveler=4 TL");
Console.WriteLine("");
Console.WriteLine("");
Console.Write("Hangi meyveyi satın almak istiyorsunuz: ");
string meyve=Console.ReadLine().ToLower();//meyve ismi  aldık ve küçük harfe dönüştürdük

//if (meyve == "Elma")
//{
//	Console.WriteLine("Sectiğiniz Meyve: 2TL");
//}
//else if (meyve == "Armut")
//{
//	Console.WriteLine("Seçtiğiniz meyve: 3TL");
//}
//else if (meyve == "Çilek")
//{
//	Console.WriteLine("Seçtiğiniz meyve: 2TL");
//}
//else if (meyve == "Muz")
//{
//	Console.WriteLine("Seçtiğiniz meyve: 4TL");
//}
//else
//{
//	Console.WriteLine("Diğer meyveler: 4Tl");
//}
switch (meyve)
{
	case  "elma":
		Console.WriteLine("Sectiğiniz Meyve: 2TL");
		break;
	case "armut":
		Console.WriteLine("Seçtiğiniz Meyve: 3TL");
		break;
	case "çilek": 
		Console.WriteLine("Seçtiğiniz Meyve: 2TL");
		break;
	case "muz":
		Console.WriteLine("Seçtiğiniz Meyve: 3TL");
		break;
	default:
		Console.WriteLine("Seçtiğiniz Meyve: 4TL");
		break;

}