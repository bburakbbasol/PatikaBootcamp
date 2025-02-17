# Ruya Manavı Programı

## Program Açıklaması
Bu program, kullanıcının seçtiği meyveye göre fiyat bilgisi veren basit bir C# konsol uygulamasıdır.

## Neden Switch-Case Yapısı Seçilmeli?

- **Okunabilirlik:** Switch-case yapısı, birden fazla durumun kontrol edilmesini kolay ve okunabilir bir şekilde sağlar.
- **Performans:** Birden fazla "if-else" kontrolü yerine switch-case kullanıldığında derleyiciler genellikle daha optimize kod oluşturur.
- **Kolay Bakım:** Yeni bir durum eklemek veya mevcut bir durumu değiştirmek daha az hata riski ile yapılabilir.
- **Anlamsal Temizlik:** Her durumun belirli bir eylemle eşleştirilmesi, kodun mantığını daha iyi ifade eder.

## Nasıl Çalışır?

1. Program, mevcut meyvelerin fiyatlarını ekrana yazdırır:
   - Elma: 2TL
   - Armut: 3TL
   - Çilek: 2TL
   - Muz: 3TL
   - Diğer bütün meyveler: 4TL

2. Kullanıcıdan bir meyve seçmesi istenir.
3. Girilen meyve, küçük harfe dönüştürülerek bir "switch" yapısında kontrol edilir:
   - Girilen meyve "elma" ise: 2TL.
   - Girilen meyve "armut" ise: 3TL.
   - Girilen meyve "çilek" ise: 2TL.
   - Girilen meyve "muz" ise: 3TL.
   - Diğer meyveler: 4TL olarak fiyatlandırılır.

## Kod Parçacığı

```csharp
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
```

## Kullanım Talimatları

1. Yukarıdaki kodu bir C# dosyasına (örneğin `Program.cs`) yapıştırın.
2. Bir C# derleyicisi veya Visual Studio gibi bir IDE kullanarak programı derleyin ve çalıştırın.
3. Konsol ekranında meyve fiyatlarını gördükten sonra bir meyve ismi girin.
4. Girilen meyveye uygun fiyat mesajını konsol ekranında görün.

## Örnek Çıktılar

### Örnek 1
**Girdi:**
```text
elma
```
**Çıktı:**
```text
Sectiğiniz Meyve: 2TL
```

### Örnek 2
**Girdi:**
```text
armut
```
**Çıktı:**
```text
Seçtiğiniz Meyve: 3TL
```

### Örnek 3
**Girdi:**
```text
ananas
```
**Çıktı:**
```text
Seçtiğiniz Meyve: 4TL
```

## Notlar

- Kullanıcıdan gelen girdi, küçük harfe dönüştürülerek kontrol edilir.
- Girilen meyve isimleri haricinde, "diğer meyveler" kategorisi fiyatı olarak 4TL belirlenmiştir.
- Kullanıcı girdisi doğrulaması yapılabilir (örneğin, boş veya sayısal olmayan girdiler için).

## Geliştirme Önerileri

1. Kullanıcı girdisini doğrulama eklemek.
2. Programı, birden fazla meyve seçimine izin verecek şekilde geliştirmek.
3. Fiyatları bir veri yapısı (örneğin, `Dictionary`) ile tutarak daha esnek bir kontrol mekanizması oluşturmak.
