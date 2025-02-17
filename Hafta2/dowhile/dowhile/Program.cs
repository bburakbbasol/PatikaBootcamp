int sayac = 0;
Console.Write(" Ben bir Patika'lıyım  kaç defa yazdırmak istersiniz: ");
int limit =Convert.ToInt32(Console.ReadLine());

while (sayac <=limit)
{
	Console.WriteLine(" Ben bir Patika'lıyım ");
	sayac++;
}
// while döngüsü, koşulun başta kontrol edilmesiyle çalışır. Eğer koşul başta sağlanmazsa, döngü hiçbir zaman çalışmaz.


int sayac1 = 0;
Console.Write("Ben bir Patika'lıyım kaç defa yazdırmak istersiniz: ");
int limit1 = Convert.ToInt32(Console.ReadLine());

do
{
	Console.WriteLine("Ben bir Patika'lıyım");
	sayac1++;
} while (sayac1 <= limit1);

// do-while döngüsü, önce döngü içindeki kodları çalıştırır ve ardından koşulu kontrol eder. Bu nedenle, koşul başta sağlanmasa bile döngü içindeki kodlar en az bir kez çalışır.