# Pratik__Constructor

Bu proje, C# dilinde constructor (yapıcı metot) kullanımı ile ilgili bir örnek içermektedir. `Bebek` sınıfı üzerinden hem parametresiz hem de parametreli yapıcı metotların nasıl kullanılacağını göstermektedir.

## Kullanılan Teknolojiler

- C# .NET
- Console Application

## Sınıf Tanımları

### Bebek Sınıfı

- **Isim**: Bebek ismini tutan özellik.
- **Soyisim**: Bebek soyismini tutan özellik.
- **DogumTarih**: Bebek doğum tarihini tutan özellik.

#### Yapıcı Metotlar

1. **Parametresiz Constructor**: Konsola varsayılan bir mesaj yazdırır.
2. **Parametreli Constructor**: İsim, soyisim ve doğum tarihi bilgileri ile nesneyi başlatır ve konsola bir mesaj yazdırır.

## Kullanım

1. **Bebek** sınıfından parametresiz bir nesne oluşturulur ve daha sonra özellikler atanır.
2. **Bebek** sınıfından parametreli bir nesne oluşturulur ve doğrudan bilgiler atanır.

## Örnek Kod

```csharp
using Pratik__Constructor;
using System;

Bebek bebek1 = new Bebek();
bebek1.Isim = "Burak";
bebek1.Soyisim = "Basol";
Console.WriteLine($"{bebek1.Isim} adında {bebek1.Soyisim} soyadında");

Bebek bebek2 = new Bebek("Ahmet", "Kaya", DateTime.Now);
Console.WriteLine($"{bebek2.Isim} adında {bebek2.Soyisim} soyadında tarihinde: {bebek2.DogumTarih} doğdum.");
