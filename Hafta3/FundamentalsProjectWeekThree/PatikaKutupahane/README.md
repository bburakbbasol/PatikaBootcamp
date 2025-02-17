# Patika Kütüphane Uygulaması

Bu proje, **Patika Kütüphane** için bir kitap kayıt uygulamasıdır. Uygulama, kitapların bilgilerini saklar ve bu bilgileri kullanıcıya sırasıyla sunar.

## Özellikler

- Kitap bilgileri (Ad, Yazar Adı, Yazar Soyadı, Sayfa Sayısı, Yayınevi, Kayıt Tarihi) saklanır.
- Statik bir liste kullanılarak tüm eklenen kitaplar depolanır ve görüntülenir.
- İki tür constructor ile kitap nesnesi oluşturulabilir:
  - **Parametreli Constructor**: Kitap bilgilerini alır ve nesneyi oluşturur.
  - **Default Constructor**: Varsayılan değerler ile kitap nesnesi oluşturur.

## Kullanılan Teknolojiler

- **C#** programlama dili
- .NET Framework

## Nasıl Çalıştırılır?

1. Projeyi klonlayın veya indirin.
2. Projeyi bir IDE (Visual Studio gibi) ile açın.
3. `Program.cs` dosyasını çalıştırın.
4. Örnek kitap bilgileri eklenir ve tüm kitaplar konsola yazdırılır.

## Örnek Kullanım

```csharp
Kitaplik kitap1 = new Kitaplik("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
Kitaplik kitap2 = new Kitaplik("Kuyucaklı Yusuf", "Sabahattin", "Ali", 160, "Yapı Kredi Yayınları");

Kitaplik.TumKitaplariYazdir();
