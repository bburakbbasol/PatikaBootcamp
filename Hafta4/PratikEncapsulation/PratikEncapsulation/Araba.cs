using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PratikEncapsulation
{
	internal class Araba
	{
		// Özel alanlar (field) tanımlandı
		private string _marka;
		private int _model;
		private string _renk;
		private int _kapi;

		// Yapıcı metot (constructor) ile araba nesnesi oluşturulurken değerler atanır
		public Araba(string marka, int model, string _renk, int _kapi)
		{
			_marka = marka;
			_model = model; 
			_renk = _renk; 
			Kapi = _kapi; 
		}

		// Marka property'si, sadece get erişimcisi ile okuma işlemi yapar
		public string Marka
		{
			get
			{
				return _marka;
			}
		}

		// Model property'si, sadece get erişimcisi ile okuma işlemi yapar
		public int Model
		{
			get
			{
				return _model;
			}
		}

		// Renk property'si, hem get hem de set erişimcisi ile okuma ve yazma işlemi yapar
		public string Renk
		{
			get
			{
				return _renk;
			}
			set
			{
				_renk = value; // Renk güncellenebilir
			}
		}

		// Kapı sayısı property'si, hem get hem de set erişimcisi ile okuma ve yazma işlemi yapar
		public int Kapi
		{
			get
			{
				return _kapi;
			}
			set
			{
				// Kapı sayısı sadece 2 veya 4 olabilir, aksi halde -1 atanır
				if (!(value == 2 || value == 4))
				{
					_kapi = -1; // Geçersiz kapı sayısı
				}
				else
				{
					_kapi = value; // Geçerli kapı sayısı atanır
				}
			}
		}

		// Araba bilgilerini konsola yazdıran metot
		public void ArabaGoster()
		{
			Console.WriteLine($"Arabanın modeli: {_model}, markası {_marka}, arabanın rengi: {_renk}, araba {_kapi} kapılıdır");
		}
	}
}

