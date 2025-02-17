# Hafta5Kapanis Projesi

Bu proje, kullanıcıdan araba bilgilerini alarak bir listeye ekleyen ve bu listeyi daha sonra görüntüleyen basit bir C# konsol uygulamasıdır.

## Özellikler

- Kullanıcıdan araba bilgilerini alır (seri numarası, marka, model, renk, kapı sayısı).
- Kullanıcının istediği kadar araba eklemesine izin verir.
- Girilen arabaları bir listeye ekler.
- Kullanıcı "hayır" dediğinde, eklenen arabaları listeler ve programı sonlandırır.
- Üretim tarihi otomatik olarak o anki tarih ve saat olarak belirlenir.

## Kullanım

1. Uygulamayı çalıştırın.
2. Araba üretmek isteyip istemediğinizi soran bir mesaj alacaksınız. 
   - `e` yazarak yeni bir araba eklemeye başlayabilirsiniz.
   - `h` yazarak programı sonlandırabilirsiniz.
3. Araba bilgilerini sırasıyla girin:
   - Seri numarası
   - Marka
   - Model (sayı olarak)
   - Renk
   - Kapı sayısı (sayı olarak)
4. Bilgiler doğru girildikten sonra araba listeye eklenir.
5. `h` yazarak araba eklemeyi durdurabilir ve listeyi görüntüleyebilirsiniz.

## Kod Yapısı

- **Araba Sınıfı**: `Araba` sınıfı, araba özelliklerini (seri numarası, marka, model, renk, kapı sayısı) ve üretim tarihini içerir. Üretim tarihi otomatik olarak atanır.
- **Program Sınıfı**: `program` sınıfı, kullanıcıdan giriş almak ve araba listesini yönetmek için bir döngü içerir.

## Örnek Kullanım

