# Kullanıcıya Yönelik Açıklama

Bu program, kullanıcıya üç farklı seçenek sunan bir konsol uygulamasıdır. Kullanıcı, seçtiği seçeneğe bağlı olarak bir oyun oynayabilir veya bir işlem gerçekleştirebilir.

---

## Programın İşlevleri

### 1. Rastgele Sayı Bulma Oyunu
Kullanıcı, 1 ile 100 arasında rastgele seçilmiş bir sayıyı tahmin etmeye çalışır. Program, kullanıcıya doğru tahmine ulaşabilmesi için bir aralık sunar ve 5 tahmin hakkı verir.

#### Kurallar:
- Kullanıcı geçerli bir sayı (1-100) girmelidir.
- Tahmin doğru olduğunda kullanıcı tebrik edilir.
- Tahmin yanlışsa program kalan tahmin hakkını ve aralığı gösterir.

#### Oyun Akışı:
- Rastgele bir sayı üretilir.
- Kullanıcıdan tahmin yapması istenir.
- 5 tahmin hakkı boyunca kullanıcı doğru tahmini bulamazsa rastgele sayı açıklanır.

---

### 2. Hesap Makinesi
Kullanıcı iki sayı ve bir matematiksel işlem türü girer. Program, bu işlem doğrultusunda sonucu ekrana yansıtır.

#### Desteklenen İşlemler:
- Toplama (`+`)
- Çıkarma (`-`)
- Çarpma (`*`)
- Bölme (`/`)

#### Kurallar:
- İşlem türü geçerli olmalıdır (`+`, `-`, `*`, `/`).
- Bölme işleminde sıfıra bölme hatası kontrol edilir.

#### Akış:
1. Kullanıcı iki sayı girer.
2. İşlem türünü seçer.
3. Sonuç hesaplanarak ekrana yazdırılır.

---

### 3. Ortalama Hesaplama
Kullanıcı üç ders notu girerek ortalamasını hesaplar ve bu ortalamaya göre bir harf notu alır.

#### Kurallar:
- Her ders notu 0 ile 100 arasında olmalıdır.
- Geçersiz bir giriş yapılırsa kullanıcı bilgilendirilir ve işlem sonlandırılır.

#### Harf Notları:
| Ortalama Aralığı | Harf Notu |
|------------------|-----------|
| 90-100           | AA        |
| 85-89            | BA        |
| 80-84            | BB        |
| 75-79            | CB        |
| 70-74            | CC        |
| 65-69            | DC        |
| 60-64            | DD        |
| 55-59            | FD        |
| 0-54             | FF        |

---

## Programın Çalıştırılması

1. **Kodun Derlenmesi ve Çalıştırılması**:
   - Uygulamayı Visual Studio veya herhangi bir C# derleyici ile çalıştırabilirsiniz.
2. **Seçim Yapma**:
   - Program çalıştırıldığında kullanıcıdan bir seçenek (1, 2 veya 3) yapması istenir.

---

## Kullanıcıya Yönelik Mesajlar
- Geçersiz girişler için program kullanıcıyı bilgilendirir.
- Oyunlar ve işlemler sırasında her adım açıkça açıklanır.
- Sonuçlar ve hata durumları detaylı bir şekilde ekrana yazdırılır.

---

## Geliştirici Notları
Bu program, C# dilinde temel kullanıcı giriş-çıkış işlemleri, kontrol yapıları ve döngüleri kullanarak oluşturulmuştur. Farklı işlevler için mantıksal bloklar arasında ayrım yapılmıştır ve kullanıcı dostu bir deneyim sunması hedeflenmiştir.
