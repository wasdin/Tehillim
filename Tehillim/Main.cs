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
			AuthorisedVersion builder = new AuthorisedVersion ();
			Console.WriteLine(builder.getPsalm (1));

			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();




		}
	}
}
