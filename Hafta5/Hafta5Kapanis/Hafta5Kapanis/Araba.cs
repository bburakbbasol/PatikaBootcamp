using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5Kapanis
{
	public class Araba
	{
		private DateTime _uretimTarihi;
		public DateTime uretimTarihi
		{
			get
			{
				return _uretimTarihi;
			}

			set
			{
				_uretimTarihi = DateTime.Now;

			}
		}
		public string seriNo { get; set; }
		public string marka { get; set; }
		public int model {  get; set; }
			
		
		public string renk { get; set; }
		public int kapiSayisi { get; set; }

	}
}
