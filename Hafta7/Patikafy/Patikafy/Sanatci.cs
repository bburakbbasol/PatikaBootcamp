using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikafy
{
	internal class Sanatci
	{
		public string AdSoyad { get; set; }
		public string Tur {  get; set; }

		public int CikisYıl {  get; set; }
		public int Satis {get; set; }

		public Sanatci(string adSoyad, int satis, int cikisY, string tur)
		{
			AdSoyad = adSoyad;
			Tur = tur;
			CikisYıl = cikisY;
			Satis = satis;
		}

	}
}
