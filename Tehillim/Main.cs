using System;
using Gtk;

namespace Tehillim
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();

		Psalm[] psalms = new Psalm[150];
		psalms [117] = new Psalm (117, "Psalm 117", Tehillim.Meter.CommonMeter);
		psalms [117].verses.Add ("O give ye praise unto the Lord, \n\tall nations that be; \nLikewise, ye people all, accord \n\this name to magnify.");
		psalms [117].verses.Add ("\nFor great to us-ward ever are \n\this loving-kindnesses: \nHis truth endures for evermore. \n\tThe Lord O do ye bless.");

			Console.WriteLine (psalms[117]);

		}
	}
}
