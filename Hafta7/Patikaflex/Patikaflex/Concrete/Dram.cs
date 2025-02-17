using Patikaflex.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikaflex.Concrete
{
	internal class Dram : TvSeries
	{
		public Dram(string name, int productionYear, int relaseTime, string director, string streamingPlatform) : base(name, productionYear, relaseTime, director, streamingPlatform)
		{
			Genre = "Dram";
		}
		public override void InfoTvSeries()
		{
			Console.WriteLine($"{Name} {ProductionYear}'da yapımı başlamış {Genre} türünde bir dizidir.Bu dizi {ReleaseDate} yılında  {StreamingPlatform} kanalında yayınlanmış ve {Director} yönetmenidir. ");
		}
	}
}
