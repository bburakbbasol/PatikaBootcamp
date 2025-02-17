# C# ile Dizi İşlemleri Örneği

Bu proje, C# dilinde temel dizi işlemlerini içermektedir. Kullanıcıdan giriş alma, diziyi yeniden boyutlandırma ve sıralama işlemleri adım adım gösterilmektedir. Kodda gerçekleştirilen işlemler aşağıda açıklanmıştır:

## Adımlar:

1. **Dizi Tanımlama**:
   - `sayilar` adında, 10 elemanlı bir tam sayı dizisi tanımlanmıştır.

2. **Kullanıcı Girişi**:
   - Program, kullanıcıdan 10 adet tam sayı değeri girmesini ister ve bu değerleri `sayilar` dizisinde saklar.

3. **Dizi Elemanlarını Gösterme**:
   - `foreach` döngüsü kullanılarak dizinin elemanları ekrana yazdırılır.

4. **11. Elemanı Eklemek**:
   - Program, kullanıcıdan ek bir tam sayı (11. değer) girmesini ister.
   - `Array.Resize` metodu ile dizinin boyutu bir artırılır.
   - Yeni değer, dizinin sonuna eklenir.

5. **Sıralama**:
   - `Array.Sort` metodu kullanılarak dizi küçükten büyüğe sıralanır.
   - Daha sonra, `Array.Reverse` metodu ile dizi ters çevrilerek büyükten küçüğe sıralama elde edilir.

6. **Sonuçların Ekrana Yazdırılması**:
   - Büyükten küçüğe sıralanan dizi, `for` döngüsü ile ekrana yazdırılır.

