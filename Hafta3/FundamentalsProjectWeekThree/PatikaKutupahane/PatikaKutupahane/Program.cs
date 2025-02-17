using PatikaKutupahane;
// Parametreli constructor kullanarak kitap nesnesi oluşturma
Kitaplik Kitap1 = new Kitaplik("Bir Kitap", "Ahmet", "Yılmaz",320,"Alfa Yayınları");
// Default constructor kullanarak kitap nesnesi oluşturma
Kitaplik Kitap2 = new Kitaplik();

Kitap2.Ad = "Başka Bir Kitap";
Kitap2.YazarAdi = "Ayşe";
Kitap2.YazarSoyadi = "Karan";
Kitap2.SayfaSayisi = 215;
Kitap2.YayinEvi = "Beta Yayin Evi";
Kitap1.KitapBilgi();
Kitap2.KitapBilgi();
