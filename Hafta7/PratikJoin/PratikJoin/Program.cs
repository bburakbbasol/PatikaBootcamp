using System;
using System.Security.Cryptography;

public class program
{
	// Yazar sınıfı tanımlandı
	public class Author
	{
		public int AuthorId { get; set; } // Yazarın benzersiz kimliği
		public string Name { get; set; } // Yazarın adı
	}

	// Kitap sınıfı tanımlandı
	public class Book
	{
		public int BookId { get; set; } // Kitabın benzersiz kimliği
		public string Title { get; set; } // Kitabın başlığı
		public int AuthorId { get; set; } // Kitabın yazar kimliği (AuthorId ile ilişkilendirilir)
	}

	static void Main(string[] args)
	{
		// Yazarların olduğu liste oluşturuldu
		List<Author> authors = new List<Author>()
		{
			new Author { AuthorId = 1, Name="Orhan Pamuk"},
			new Author { AuthorId = 2, Name="Elif Şafak" },
			new Author { AuthorId = 3, Name="Sabahattin Ali"},
			new Author { AuthorId = 4, Name="Aytuğ Akdoğan" }
		};

		// Kitapların olduğu liste oluşturuldu
		List<Book> books = new List<Book>()
		{
			new Book { BookId = 1, Title="Kırmızı Saçlı Kadın", AuthorId=1},
			new Book { BookId = 2, Title="Aşk", AuthorId=2 },
			new Book { BookId = 3, Title="Kar", AuthorId=1 },
			new Book { BookId = 4, Title="Sırçalı Köşk", AuthorId=3 },
			new Book { BookId = 5, Title="Sürgün", AuthorId=4 },
			new Book { BookId = 6, Title="Duvar", AuthorId=4 }
		};

		// Yazarlar ile kitapları birleştiren sorgu LINQ kullanılarak oluşturuldu
		var query = (from book in books
					 join author in authors
					 on book.AuthorId equals author.AuthorId
					 select new
					 {
						 BookTitle = book.Title, // Kitap başlığı
						 AuthorName = author.Name // Yazarın adı
					 }).OrderBy(x => x.AuthorName); // Sonuçları yazar adına göre sıralar

		// Sorgu sonucu ekrana yazdırılır
		foreach (var item in query)
		{
			Console.WriteLine($"{item.AuthorName}, {item.BookTitle} kitabının yazarıdır.");
		}
	}
}
