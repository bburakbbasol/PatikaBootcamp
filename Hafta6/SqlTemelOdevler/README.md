# SQL Ödevleri - Genel Mantık ve Amaç

Bu çalışma, temel ve ileri düzey SQL sorgularının mantığını anlamaya yöneliktir. Aşağıda, her sorgu grubunun ne tür veri manipülasyonu yapmayı hedeflediği açıklanmaktadır.

---

## 1. Temel SELECT ve WHERE Sorguları
**Amaç:** 
- Veritabanındaki belirli tablolardan verileri seçmek ve şartlara bağlı olarak filtrelemek. 
- Örneğin, bir film listesinde belirli uzunluktaki filmleri veya belirli fiyat aralığındaki öğeleri bulmak.

**Kullanılan Mantık:**
- Verileri tablo sütunlarından seçmek için `SELECT`.
- Şartlı filtreleme için `WHERE` ve mantıksal operatörler (`AND`, `OR`, `NOT`).

---

## 2. Çoklu Şartlı Filtreleme
**Amaç:**
- Veritabanındaki verileri belirli bir aralıkta (`BETWEEN`) veya belirli bir dizi değere (`IN`) göre filtrelemek.
- Örneğin, belirli maliyet aralığında olan filmleri veya belirli oyuncuları seçmek.

**Kullanılan Mantık:**
- Aralık bazlı filtreleme için `BETWEEN`.
- Belirli bir grup değerle karşılaştırma için `IN`.

---

## 3. Karakter Tabanlı Arama (LIKE ve Regex)
**Amaç:**
- Belirli bir harf veya karakter dizisiyle başlayan, biten ya da belirli bir kalıba uyan verileri bulmak.
- Örneğin, isimleri belirli bir harfle başlayan ülkeleri veya başlığında belirli bir sayıda harf bulunan filmleri bulmak.

**Kullanılan Mantık:**
- Karakter eşleşmeleri için `LIKE` veya regex benzeri `~~`.

---

## 4. Benzersiz Değerler (DISTINCT ve COUNT)
**Amaç:**
- Tekrarlayan verileri kaldırmak ve benzersiz değerlerin sayısını bulmak.
- Örneğin, film tablosunda yalnızca benzersiz değiştirme maliyetlerini ya da belirli bir harfle başlayan benzersiz başlıkları bulmak.

**Kullanılan Mantık:**
- Tekrarlayan verileri kaldırmak için `DISTINCT`.
- Kayıtların sayısını hesaplamak için `COUNT`.

---

## 5. Sıralama ve Limitleme (ORDER BY, LIMIT, OFFSET)
**Amaç:**
- Verileri belirli bir sıraya göre düzenlemek ve yalnızca istenen sayıda sonuç döndürmek.
- Örneğin, en uzun 5 filmi veya bir aralıktaki diğer filmleri bulmak.

**Kullanılan Mantık:**
- Sıralama için `ORDER BY`.
- Sonuçları sınırlandırmak için `LIMIT` ve atlama yapmak için `OFFSET`.

---

## 6. Toplama ve İstatistiksel Fonksiyonlar (SUM, MAX, COUNT)
**Amaç:**
- Toplamları hesaplamak, maksimum veya minimum değerleri bulmak ve kayıtları saymak.
- Örneğin, tüm filmlerin toplam kiralama oranını veya belirli kriterlere uyan filmlerin sayısını bulmak.

**Kullanılan Mantık:**
- Toplama fonksiyonları: `SUM`, `MAX`, `COUNT`.

---

## 7. Gruplama ve Filtreleme (GROUP BY, HAVING)
**Amaç:**
- Verileri gruplandırarak istatistiksel bilgiler üretmek ve gruplar üzerinde filtre uygulamak.
- Örneğin, her mağazada kaç müşteri olduğunu veya 50’den fazla filmi olan maliyetleri bulmak.

**Kullanılan Mantık:**
- Gruplama yapmak için `GROUP BY`.
- Gruplar üzerinde filtreleme yapmak için `HAVING`.

---

## Genel Sonuç
Bu ödev, SQL’in veri seçme, filtreleme, gruplama ve sıralama gibi temel ve ileri düzey yeteneklerini kavramak için bir temel sunmaktadır. SQL sorgularını yazarken, kullanılan her komutun spesifik bir amaca hizmet ettiği unutulmamalıdır.
