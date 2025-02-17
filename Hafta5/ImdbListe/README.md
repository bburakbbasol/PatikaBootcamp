# IMDb Film Listeleme Uygulaması

Bu uygulama, kullanıcıdan film isimleri ve IMDb puanlarını alarak bir liste oluşturur. Kullanıcıya film ekleme, sıralama ve filtreleme gibi işlemleri gerçekleştirme imkanı sunar.

## Özellikler
- Kullanıcıdan film ismi ve IMDb puanı alınır.
- Filmler IMDb puanlarına göre küçükten büyüğe sıralanır.
- Kullanıcıya belirli IMDb puan aralıklarına göre (4 ile 9 arasındaki filmler) listeleme yapılır.
- Kullanıcıdan alınan verilerle "A" harfiyle başlayan filmler listelenir.

## Kullanıcı Akışı
1. **Film Ekleme**: Uygulama sürekli olarak kullanıcıdan film ismi ve IMDb puanı alır.
2. **Başka Film Ekleme**: Kullanıcı film eklemek için "evet" cevabını verir veya "hayır" diyerek işlem tamamlanır.
3. **Film Listeleme**: Kullanıcı verileri tamamladıktan sonra filmler sıralanır ve ekranda gösterilir.
4. **Sıralama**: Filmler IMDb puanına göre sıralanır ve ekrana yazdırılır.
5. **Filtreleme**: IMDb puanı 4 ile 9 arasında olan filmler ayrıca listelenir.
6. **A Harfiyle Başlayan Filmler**: "A" harfi ile başlayan filmler ayrı bir şekilde ekranda gösterilir.

## Kullanım
1. **Film İsmi**: Kullanıcı film ismini girecektir.
2. **IMDb Puanı**: Kullanıcı film puanını girerken yalnızca sayısal değerler kabul edilir.
3. **Film Listesi**: Ekranda, sıralanmış ve filtrelenmiş şekilde filmler gösterilir.

## Kod Açıklamaları

- `filmler.Sort((x, y) => x.ImdbPuani.CompareTo(y.ImdbPuani));` 
  - Bu ifade, filmleri IMDb puanlarına göre küçükten büyüğe sıralamak için kullanılır. `CompareTo` metodu, iki filmin IMDb puanını karşılaştırır.

- `filmler.Reverse();`
  - Bu metot, filmleri ters sırayla (büyükten küçüğe) sıralar.

- `var aHarfiBaslayanFilm = filmler.Where(f => f.FilmIsmi.StartsWith("A")).ToList();`
  - Bu ifade, ismi "A" harfiyle başlayan filmleri filtreler.
