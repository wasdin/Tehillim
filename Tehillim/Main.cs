using System;
using System.IO;
using System.Collections.Generic;
using Gtk;
using Newtonsoft.Json;

namespace Tehillim
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Application.Init ();
			//MainWindow win = new MainWindow ();
			//win.Show ();
			//Application.Run ();

			SMV_Builder builder = new SMV_Builder();
			builder.build ();


			//Console.WriteLine (list.Count);
		}
	}
}
