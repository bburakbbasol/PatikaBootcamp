# **E-Commerce .NET Backend Projesi**

Bu proje, .NET teknolojisi kullanılarak geliştirilmiş bir e-ticaret backend uygulamasıdır. Uygulama, kategori yönetimi, müşteri işlemleri, sipariş yönetimi ve ürün güncelleme gibi temel e-ticaret işlemlerini gerçekleştirmek için tasarlanmıştır. Projede Entity Framework Core kullanılarak veri tabanı yönetimi sağlanmış ve RESTful API standartlarına uygun olarak geliştirilmiştir.

---

## **Proje Kurulumu**

1. **Depoyu Klonlayın:**
   ```sh
   git clone https://github.com/bburakbbasol/PatikaBootcamp.git
   ```
2. **Gerekli Bağımlılıkları Yükleyin:**
   ```sh
   dotnet restore
   ```
3. **Veri Tabanını Yapılandırın:**
   - `appsettings.json` dosyasındaki bağlantı ayarlarını kendi veri tabanınıza göre düzenleyin.
   - Code First yaklaşımı ile migration işlemlerini gerçekleştirin:
     ```sh
     dotnet ef migrations add InitialCreate
     dotnet ef database update
     ```
4. **Projeyi Çalıştırın:**
   ```sh
   dotnet run
   ```

---

## **Proje İçeriği ve Kod Açıklamaları**

### **1. Kategori Yönetimi (CategoriesController)**
Bu controller, kategorilerle ilgili işlemleri yönetir.

- **GetById(int id):** Belirtilen ID'ye sahip kategoriyi getirir.
- **Create(Category category):** Yeni bir kategori oluşturur ve aynı zamanda bir ürün ekler.

### **Kod Açıklamaları:**
```csharp
[HttpGet("{id}")]
public async Task<ActionResult<Category>> GetById(int id)
{
    var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
    if (category == null) return NotFound();
    return Ok(category);
}
```
Bu metod, gelen ID'ye göre kategoriyi bulur. Eğer kategori bulunamazsa `404 Not Found` hatası döner.

```csharp
[HttpPost]
public async Task<ActionResult<Category>> Create(Category category)
{
    _context.Categories.Add(category);
    await _context.SaveChangesAsync();
    return CreatedAtAction(nameof(GetById), new { id = category.Id }, category);
}
```
Bu metod yeni bir kategori ekler ve başarılı olduğunda, oluşturulan kategorinin detaylarını döndürür.

---

### **2. Müşteri Yönetimi (CustomersController)**
Bu controller, müşteri yönetimini sağlar.

- **GetById(int id):** Belirtilen ID'ye sahip müşteriyi getirir.
- **Create(Customer customer):** Yeni bir müşteri oluşturur.
- **GetCustomers(CustomerFilterDto filter):** Filtrelenmiş müşteri listesini döndürür.

### **Kod Açıklamaları:**
```csharp
[HttpGet("{id}")]
public async Task<ActionResult<Customer>> GetById(int id)
{
    var customer = await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);
    if (customer == null) return NotFound();
    return Ok(customer);
}
```
Bu metod, müşterinin ID’sine göre verileri getirir.

---

### **3. Sipariş Yönetimi (OrdersController)**
Bu controller, sipariş işlemlerini yönetir.

- **GetByInt(int id):** Belirtilen ID'ye sahip siparişi getirir.
- **Create(CreateOrderDto order):** Yeni bir sipariş oluşturur.
- **DeletOldOrders(int yearsOld):** Belirli bir yıldan eski siparişleri siler.

### **Transaction ve Rollback Mekanizması**
Sipariş oluşturma işlemi sırasında transaction yapısı kullanılmıştır. Eğer sipariş eklenirken bir hata oluşursa, `Rollback` işlemi ile veritabanındaki değişiklikler geri alınır.

```csharp
using var transaction = await _context.Database.BeginTransactionAsync();
try
{
    var newOrder = new Order { CustomerId = order.CustomerId, OrderDate = DateTime.Now, TotalAmount = 0 };
    _context.Add(newOrder);
    await _context.SaveChangesAsync();
    decimal totalAmount = 0;

    foreach(var item in order.OrderItems)
    {
        var product = await _context.Products.FindAsync(item.productId);
        if (product == null) throw new Exception("Ürün bulunamadı");
        if (product.StockQuantity < item.quantity) throw new Exception("Yetersiz stok");

        var orderDetail = new OrderDetail
        {
            OrderId = newOrder.Id,
            ProductId = product.Id,
            Quantity = item.quantity,
            UnitPrice = product.Price
        };
        _context.OrderDetails.Add(orderDetail);
        totalAmount += orderDetail.Quantity * orderDetail.UnitPrice;
        product.StockQuantity -= item.quantity;
        _context.Products.Update(product);
    }

    newOrder.TotalAmount = totalAmount;
    _context.Orders.Update(newOrder);
    await _context.SaveChangesAsync();
    await transaction.CommitAsync();
    return CreatedAtAction(nameof(GetByInt), new { id = newOrder.Id }, newOrder);
}
catch (Exception ex)
{
    transaction.Rollback();
    return StatusCode(500, "Hata oluştu: " + ex.Message);
}
```
Bu kod bloğu, sipariş ekleme işlemini bir transaction içinde gerçekleştirir. Eğer işlem sırasında hata oluşursa, `Rollback()` fonksiyonu çağrılarak yapılan tüm işlemler iptal edilir ve veri bütünlüğü korunur.

---

## **API Kullanımı**
Projede oluşturulan API'yi Postman veya Swagger üzerinden test edebilirsiniz. API uç noktaları için Swagger UI kullanılmaktadır.

1. Projeyi çalıştırın.
2. Tarayıcınızda aşağıdaki URL'yi açın:
   ```
   http://localhost:<port>/swagger/index.html
   ```
3. Buradan mevcut API uç noktalarını görebilir ve test edebilirsiniz.

---

## **Katkıda Bulunma**
Projeye katkıda bulunmak için pull request açabilirsiniz. Hata bildirimi veya geliştirme önerileri için issue oluşturabilirsiniz.

---

## **Lisans**
Bu proje MIT lisansı ile sunulmaktadır. Detaylar için [LICENSE](LICENSE) dosyasını inceleyebilirsiniz.

---

Bu proje, .NET backend geliştirme sürecini öğrenmek isteyenler için hazırlanmıştır. Sorularınızı veya geliştirme önerilerinizi paylaşmaktan çekinmeyin! 🚀

