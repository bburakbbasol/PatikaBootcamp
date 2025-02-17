using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikaflex.Abstract
{
	public abstract class TvSeries
	{
		public string Name { get; set; }
		public int ProductionYear { get; set; }
		public string Genre { get; set; }
		public int ReleaseDate { get; set; }
		public string Director { get; set; }
		public string StreamingPlatform { get; set; }

		public TvSeries(string name, int productionYear, int relaseTime, string director, string streamingPlatform)
		{
			Name = name;
			ProductionYear = productionYear;
			ReleaseDate = relaseTime;
			Director = director;
			StreamingPlatform = streamingPlatform;

		}
		public abstract void InfoTvSeries();



	}
	
}
