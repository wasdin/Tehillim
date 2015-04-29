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

			StreamReader re = File.OpenText("../../smv_1650.json");
			JsonTextReader jsonReader = new JsonTextReader(re);
			JsonSerializer jsonSerializer = new JsonSerializer();
			object parsedData = jsonSerializer.Deserialize(jsonReader);

			List<RootObject> list = new List<RootObject>();

			while (jsonReader.Read())
            {
                Console.WriteLine(jsonReader.Value);
				String temp = jsonReader.Value.ToString ();
				list.Add(JsonConvert.DeserializeObject<RootObject>(temp));

            }
            jsonReader.Close();

			Console.WriteLine (list.Count);
		}
	}
}
