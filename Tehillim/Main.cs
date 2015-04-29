using System;
using Gtk;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

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

		String json = "";
		using (StreamReader r = new StreamReader("smv_1650.json"))
   	 	{
        	json = r.ReadToEnd();
    	}

		dynamic array = JsonConvert.DeserializeObject(json);
		foreach(var item in array)
		{
   			Console.WriteLine("{0} {1}", item.temp, item.vcc);
		}

		}
	}
}
