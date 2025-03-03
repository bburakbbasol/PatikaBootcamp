# Proje Adı

Bu proje, .NET Core ve Entity Framework Core kullanılarak geliştirilmiş bir RESTful API'dir. Uygulama, veritabanı işlemleri ve CRUD operasyonlarını yönetmek için geliştirilmiştir.

## Kurulum

1. Projeyi klonlayın:
   ```sh

2. Gerekli bağımlılıkları yükleyin:
   ```sh
   dotnet restore
   ```
3. Veritabanını oluşturun ve migrate işlemlerini gerçekleştirin:
   ```sh
   dotnet ef database update
   ```
4. Uygulamayı başlatın:
   ```sh
   dotnet run
   ```

## Kullanım
API, aşağıdaki uç noktaları (endpoints) içerir:

### Genel CRUD İşlemleri

- **Tüm verileri getir**
  ```http
  GET /api/[controller]
  ```
- **Belirtilen ID'ye sahip veriyi getir**
  ```http
  GET /api/[controller]/{id}
  ```
- **Yeni bir veri ekle**
  ```http
  POST /api/[controller]
  ```
  - **Gövde (Body) Örneği:**
    ```json
    {
      "name": "Örnek Veri",
      "description": "Bu bir açıklamadır."
    }
    ```
- **Mevcut bir veriyi güncelle**
  ```http
  PUT /api/[controller]/{id}
  ```
  - **Gövde (Body) Örneği:**
    ```json
    {
      "name": "Güncellenmiş Veri",
      "description": "Güncellenmiş açıklama."
    }
    ```
- **Belirtilen ID'ye sahip veriyi sil**
  ```http
  DELETE /api/[controller]/{id}
  ```

## Teknolojiler
- .NET Core
- Entity Framework Core
- ASP.NET Core Web API
- SQL Server



## Lisans
Bu proje MIT lisansı ile lisanslanmıştır.

