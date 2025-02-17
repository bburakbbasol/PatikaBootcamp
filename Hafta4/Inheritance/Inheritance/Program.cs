using Inheritance;

Ogrenci ogrenci1 = new Ogrenci();
ogrenci1.Ad = "Burak";
ogrenci1.Soyad = "Başol";
ogrenci1.OgrenciNumarasi = 1813456789;
ogrenci1.OgrenciBilgi();
Ogretmen ogretmen=new Ogretmen();
ogretmen.Ad = "İsmail";
ogretmen.Soyad = "Saymaz";
ogretmen.Maas = 45897;
ogretmen.OgretmenBilgi();
ogrenci1.Yazdir();