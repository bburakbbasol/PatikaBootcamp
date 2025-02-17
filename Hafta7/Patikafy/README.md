# Patikafy Sanatçı Analiz Projesi

Bu proje, C# dilinde yazılmış bir konsol uygulamasıdır. Uygulama, bir sanatçı listesi üzerinden çeşitli analizler yapar ve belirli kriterlere göre filtreleme işlemleri gerçekleştirir.

## Proje Özeti

Bu proje, popüler sanatçılarla ilgili verileri saklamak ve bu verileri kullanarak bazı analizler yapmak için geliştirilmiştir. Analizler aşağıdaki kriterlere göre yapılır:

1. **Adı "S" ile başlayan sanatçılar**
2. **Satışları 10 milyonun üzerinde olan sanatçılar**
3. **2000'den önce çıkış yapmış ve pop müziği yapan sanatçılar**
4. **En çok albüm satan sanatçı**
5. **En yeni ve en eski çıkış yapan sanatçılar**

## Kullanılan Teknolojiler

- **C#**: Uygulama, C# dilinde yazılmıştır.
- **LINQ**: Liste elemanlarını filtrelemek, sıralamak ve gruplamak için LINQ kullanılmıştır.

## Kullanıcıya Sunulan Fonksiyonlar

### 1. Adı "S" ile başlayan sanatçılar
Liste içerisinde adı "S" harfi ile başlayan sanatçılar listelenir.

### 2. Satışları 10 milyonun üzerinde olan sanatçılar
10 milyonun üzerinde albüm satmış sanatçılar ekrana yazdırılır.

### 3. 2000'den önce çıkış yapmış ve pop müziği yapan sanatçılar
2000'den önce çıkış yapmış ve pop müziği icra eden sanatçılar gruplandırılır ve sırasıyla ekrana yazdırılır.

### 4. En çok albüm satan sanatçı
Albüm satışlarına göre sıralama yapılır ve en çok albüm satan sanatçı ekrana yazdırılır.

### 5. En yeni ve en eski çıkış yapan sanatçı
Sanatçılar çıkış yılına göre sıralanır ve en yeni ve en eski çıkış yapan sanatçılar belirlenip ekrana yazdırılır.

## Kullanıcıya Gösterilen Çıktılar

Uygulama aşağıdaki çıktıları üretir:

1. **Adı "S" ile başlayan sanatçılar**:
   - Sezen Aksu
   - Sertap Erener
   - Sıla
   - Serdar Ortaç

2. **Satışları 10 milyonun üzerinde olan sanatçılar**:
   - Ajda Pekkan
   - Tarkan
   - Gülben Ergen

3. **2000'den önce çıkış yapmış ve pop müziği yapan sanatçılar** (Gruplandırılmış):
   - 1971 yılında çıkış yapan sanatçılar:
     - Sezen Aksu
   - 1992 yılında çıkış yapan sanatçılar:
     - Tarkan
   - 1994 yılında çıkış yapan sanatçılar:
     - Sertap Erener
     - Serdar Ortaç

4. **En çok albüm satan sanatçı**:
   - Ajda Pekkan

5. **En yeni ve en eski çıkış yapan sanatçılar**:
   - En yeni çıkış yapan sanatçı: Sıla
   - En eski çıkış yapan sanatçı: Neşet Ertaş

## Kod Açıklamaları

- `Sanatci` sınıfı, her bir sanatçıyı temsil eder ve sanatçının adı, satış sayısı, çıkış yılı ve müzik türü gibi bilgileri içerir.
- `sanantcilar` listesi, sanatçıları temsil eden nesneleri barındırır.
- LINQ (Language Integrated Query) kullanarak liste üzerinde sorgular yapılır:
  - **`Where`**: Belirli koşullara uyan öğeleri filtreler.
  - **`OrderByDescending`**: Öğeleri azalan düzende sıralar.
  - **`First` / `Last`**: Liste içerisindeki ilk ve son öğeyi alır.
  - **`GroupBy`**: Elemanları belirtilen kritere göre gruplar.

## Projeyi Çalıştırma

1. Projeyi bir C# geliştirme ortamında açın (örneğin, Visual Studio veya Visual Studio Code).
2. Programı çalıştırarak analizleri ve çıktıları görebilirsiniz.

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakabilirsiniz.
