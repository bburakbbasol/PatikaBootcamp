# PratikAbstraction

Bu proje, C# dilinde soyutlama (abstraction) ve arayüz (interface) kullanımını gösteren bir örnektir.

## Yapı

- **IEmployee**:
  - Ortak özellikler (`Name`, `Surname`) ve `Title()` metodunu tanımlayan bir arayüz.
  
- **SoftwareDevoloper**:
  - Yazılım Geliştirici sınıfı, `IEmployee` arayüzünü uygular ve unvanını yazdırır.
  
- **ProjectManager**:
  - Proje Yöneticisi sınıfı, `IEmployee` arayüzünü uygular ve unvanını yazdırır.
  
- **SalesRepresentative**:
  - Satış Temsilcisi sınıfı, `IEmployee` arayüzünü uygular ve unvanını yazdırır.

## Kullanım

Her çalışan sınıfı, `Title()` metodu ile ad, soyad ve unvan bilgilerini konsola yazdırır.

