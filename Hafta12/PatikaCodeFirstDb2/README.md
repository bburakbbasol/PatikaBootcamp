# PatikaCodeFirstDb2

## 📌 Proje Açıklaması

Bu proje, **Entity Framework Core** kullanarak **Code First** yaklaşımıyla bir veritabanı oluşturmayı amaçlamaktadır. Projede **User (Kullanıcı)** ve **Post (Gönderi)** olmak üzere iki tablo bulunmaktadır. **Bir kullanıcı birden fazla gönderiye sahip olabilir (One-to-Many İlişki).**

## 🛠 Kullanılan Teknolojiler

- .NET 7 / .NET 8
- Entity Framework Core
- Microsoft SQL Server
- C#

---

## 📂 Proje Yapısı

```
📦 PatikaCodeFirstDb2
 ┣ 📂 Models
 ┃ ┣ 📜 User.cs
 ┃ ┣ 📜 Post.cs
 ┣ 📂 Data
 ┃ ┣ 📜 PatikaSecondDbContext.cs
 ┣ 📜 appsettings.json
 ┣ 📜 Program.cs
 ┣ 📜 README.md
```

---

## 📋 Veritabanı Modeli

### **User (Kullanıcı) Tablosu**

| Alan Adı | Veri Tipi | Açıklama                         |
| -------- | --------- | -------------------------------- |
| Id       | int       | Birincil anahtar, otomatik artan |
| Username | string    | Kullanıcı adı                    |
| Email    | string    | Kullanıcının e-posta adresi      |

### **Post (Gönderi) Tablosu**

| Alan Adı | Veri Tipi | Açıklama                           |
| -------- | --------- | ---------------------------------- |
| Id       | int       | Birincil anahtar, otomatik artan   |
| Title    | string    | Gönderinin başlığı                 |
| Content  | string    | Gönderinin içeriği                 |
| UserId   | int       | Kullanıcının kimliği (Foreign Key) |

---

## 🛠 Kurulum & Kullanım

### **1. Bağlantı Dizesini Güncelle**

📌 `` dosyasında bulunan **veritabanı bağlantı dizesini** kendi sisteminize göre güncelleyin:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=PatikaCodeFirstDb2;Trusted_Connection=True;TrustServerCertificate=True"
  }
}
```

### **2. Migration ve Veritabanı Güncelleme**

Aşağıdaki komutları terminalde çalıştırarak **veritabanını oluşturun**:

```sh
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### **3. Uygulamayı Çalıştırma**

```sh
dotnet run
```

---

## 🏗 Proje İçeriği

### **1. Entity Modelleri**

#### **📌 User.cs**

```csharp
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public List<Post> Posts { get; set; } = new List<Post>();
}
```

#### **📌 Post.cs**

```csharp
public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}
```

### **2. DbContext Tanımlaması**

#### **📌 PatikaSecondDbContext.cs**

```csharp
public class PatikaSecondDbContext : DbContext
{
    public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasMany(u => u.Posts)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.UserId);
    }
}
```

### **3. Program.cs İçinde Bağlantı Tanımlaması**

```csharp
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<PatikaSecondDbContext>(options => options.UseSqlServer(connectionString));
var app = builder.Build();
app.Run();
```

---

## 🎯 Sonuç

Bu proje, **Code First yaklaşımı** ile **User-Post ilişkili veritabanını oluşturmak** için temel bir altyapı sunmaktadır. Migration işlemleri tamamlandıktan sonra SQL Server üzerinde **Users ve Posts tabloları oluşturulacaktır**. 🎉

---

## 📜 Lisans

Bu proje MIT lisansı ile lisanslanmıştır.

