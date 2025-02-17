using Pratik__Constructor; // Pratik__Constructor namespace'i kullanılıyor.
using System;

Bebek bebek1 = new Bebek(); // Parametresiz constructor ile bebek1 oluşturuluyor.
bebek1.Isim = "Burak"; // Isim özelliği ayarlanıyor.
bebek1.Soyisim = "Basol"; // Soyisim özelliği ayarlanıyor.
Console.WriteLine($"{bebek1.Isim} adında {bebek1.Soyisim} soyadında "); // Bebek1 bilgileri yazdırılıyor.

Bebek bebek2 = new Bebek("Ahmet", "Kaya", DateTime.Now); // Parametreli constructor ile bebek2 oluşturuluyor.

Console.WriteLine($"{bebek2.Isim} adında {bebek2.Soyisim} soyadında tarihinde: {bebek2.DogumTarih} doğdum."); // Bebek2 bilgileri yazdırılıyor.