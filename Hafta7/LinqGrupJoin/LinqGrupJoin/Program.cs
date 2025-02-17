using System;
using System.Collections.Generic;
using System.Linq;

public class program
{
	public class Student
	{
		public int Id { get; set; }
		public string StudentName { get; set; }
		public int ClassId { get; set; }
	}

	public class Class
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
	}

	static void Main(string[] args)
	{
		// Öğrenciler listesi
		List<Student> students = new List<Student>()
		{
			new Student { Id = 1, StudentName = "Burak", ClassId = 1 },
			new Student { Id = 2, StudentName = "Ahmet", ClassId = 2 },
			new Student { Id = 3, StudentName = "Mehmet", ClassId = 3 },
			new Student { Id = 4, StudentName = "Ali", ClassId = 2 }
		};

		// Sınıflar listesi
		List<Class> classes = new List<Class>()
		{
			new Class { Id = 1, ClassName = "Matematik" },
			new Class { Id = 2, ClassName = "Fizik" },
			new Class { Id = 3, ClassName = "Beden Eğitimi" }
		};

		// GroupJoin ile sınıfları, öğrencilerle eşleştirme
		var result = classes.GroupJoin(
			students,
			c => c.Id,              // Class listesindeki Id ile eşleştirme yap
			s => s.ClassId,         // Student listesindeki ClassId ile eşleştirme yap
			(clas, studentList) => new
			{
				Class = clas.ClassName, // Sınıf adı
				Students = studentList.Select(s => s.StudentName).ToList() // Öğrenci isimleri listesi
			});

		// Sonucu ekrana yazdırma
		foreach (var group in result)
		{
			Console.WriteLine($"{group.Class} Dersi:"); // Sınıf adını ekrana yazdır

			if (group.Students.Any()) // Eğer sınıfta öğrenci varsa
			{
				foreach (var student in group.Students)
				{
					Console.WriteLine($"   - {student}"); // Öğrenciyi yazdır
				}
			}
			else
			{
				Console.WriteLine("   Bu derse kayıtlı öğrenci yok."); // Eğer sınıfta öğrenci yoksa mesaj göster
			}

			Console.WriteLine(); // Boş satır ekleyerek çıktıyı daha okunaklı hale getir
		}
	}
}
