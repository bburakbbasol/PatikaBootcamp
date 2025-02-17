# Hafta4Kapanis Uygulaması

Bu proje, **Bilgisayar** ve **Telefon** sınıflarını kullanarak farklı ürünler oluşturmanıza olanak tanır. Kullanıcı, bilgisayar veya telefon üretmek için seçenekler sunan bir konsol uygulaması ile etkileşimde bulunur.

## Proje Yapısı

### 1. BaseMakine (Soyut Sınıf)
`BaseMakine` sınıfı, tüm makineler için ortak olan özellikleri ve metotları içerir.

- **Özellikler:**
  - `UretimTarihi` : Makinenin üretim tarihi.
  - `SeriNumarası` : Makinenin seri numarası.
  - `Ad` : Makinenin adı.
  - `Aciklama` : Makinenin açıklaması.
  - `IsletimSistemi` : Makinenin işletim sistemi.

- **Soyut Metotlar:**
  - `BilgileriYazdır()` : Makine bilgilerini yazdırır.
  - `UrunAdiGetir()` : Ürünün adını yazdırır.

### 2. Bilgisayar Sınıfı
`Bilgisayar`, `BaseMakine` sınıfından türetilir ve ek olarak USB sayısı ile ilgili bir özellik içerir.

- **Ek Özellik:**
  - `UsbSayisi` : USB port sayısını tutar (sadece 2 veya 4 kabul edilir).

- **Metotlar:**
  - `BilgileriYazdır()` : Bilgisayar bilgilerini konsola yazdırır.
  - `UrunAdiGetir()` : Bilgisayar adını konsola yazdırır.

### 3. Telefon Sınıfı
`Telefon`, `BaseMakine` sınıfından türetilir ve ek olarak Türkiye lisansı ile ilgili bir özellik içerir.

- **Ek Özellik:**
  - `TrLisans` : Telefonun Türkiye lisansını tutar.

- **Metotlar:**
  - `BilgileriYazdır()` : Telefon bilgilerini konsola yazdırır.
  - `UrunAdiGetir()` : Telefon adını konsola yazdırır.

## Kullanım

Bu uygulama, kullanıcıdan hangi tür cihaz üretmek istediğini (bilgisayar veya telefon) sorar ve ardından ilgili bilgileri alarak bir nesne oluşturur.

1. Konsolda, **1** tuşlayarak bilgisayar üretimini seçebilirsiniz.
2. **2** tuşlayarak telefon üretimini seçebilirsiniz.
3. Gerekli bilgiler girildikten sonra cihaz bilgileri konsola yazdırılır.
4. Program, başka bir cihaz üretmek isteyip istemediğinizi sorar ve buna göre devam eder veya sonlanır.

## Örnek Kullanım

### Bilgisayar Üretimi:
```plaintext
Bilgisayar üretmek için 1 Telefon üretmek için 2 ye basınız: 1
Seri No giriniz: ABC123
Bilgisayar adını giriniz: Gaming PC
Açıklama: Yüksek performanslı oyun bilgisayarı
İşletim sistemini giriniz: Windows 11
USB sayısını giriniz 2 veya 4 olacak şekilde: 4
