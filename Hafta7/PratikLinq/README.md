# Sayı Filtreleme ve İşleme Uygulaması

Bu proje, verilen bir sayı listesini belirli koşullara göre filtreleyerek ekrana yazdıran bir **C# Console** uygulamasıdır.

## Özellikler

- **Çift Sayıları Listeleme:** Listedeki çift sayıları ekrana yazdırır.
- **Tek Sayıları Listeleme:** Listedeki tek sayıları ekrana yazdırır.
- **Negatif Sayıları Listeleme:** Listedeki negatif sayıları ekrana yazdırır.
- **Pozitif Sayıları Listeleme:** Listedeki pozitif sayıları ekrana yazdırır.
- **Belirli Aralıktaki Sayıları Listeleme:** 15 ile 22 arasındaki sayıları ekrana yazdırır.
- **Sayıların Karesini Hesaplama:** Listedeki her sayının karesini hesaplayıp ekrana yazdırır.

## Kullanılan Teknolojiler

- **C#**
- **.NET Console Application**
- **LINQ Sorguları** (`Where`, `Select` metodları kullanılmıştır.)

## Kurulum ve Kullanım

1. **Projeyi Çalıştırma:**
   - Proje bir **C# Console Application** olarak çalıştırılabilir.
   - `dotnet run` komutu ile çalıştırabilirsiniz.

2. **Kod İçeriği:**
   - **List<int> numbers:** İşlem yapılacak sayı listesini içerir.
   - **Where Metodu:** Sayıları belirli filtrelere göre seçmek için kullanılır.
   - **Select Metodu:** Sayıları dönüştürmek için kullanılır (örneğin, karesini almak).

## Örnek Çıktı

```text
Çift sayılar:
44
32
12
22
18

Tek Sayılar:
-5
-45
25

Negatif Sayılar:
-5
-10
-34
-45

Pozitif Sayılar:
44
32
12
22
18
25

15 ile 22 arasındaki sayılar:
18

Sayıların Karesi:
25
100
1156
2025
1936
1024
144
484
324
625
