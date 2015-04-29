using System;
using System.Collections.Generic;

namespace Tehillim
{
	public class SMV_Builder
	{
		public SMV_Builder ()
		{


		}

		public List<Psalm>[] build ()
		{
			List<Psalm>[] psalms = new List<Psalm>[150];
			psalms[117] = new List<Psalm>();
			psalms [117].Add(new Psalm (117, "Psalm 117", Tehillim.Meter.CommonMeter));
			psalms [117][0].verses.Add ("O give ye praise unto the Lord, \n\tall nations that be; \nLikewise, ye people all, accord \n\this name to magnify.");
			psalms [117][0].verses.Add ("\nFor great to us-ward ever are \n\this loving-kindnesses: \nHis truth endures for evermore. \n\tThe Lord O do ye bless.");

			return psalms;
		}

	}
}

