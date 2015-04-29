/*using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tehillim
{
	public class JsonConvertTest
	{
		public static void Main (string[] args)
		{
		JsonTextReader reader = new JsonTextReader(new StreamReader("smv_1650.json"));
		dynamic array = JsonConvert.DeserializeObject(reader);
		foreach(var item in array)
		{
   			Console.WriteLine("{0} {1}", item.temp, item.vcc);
		}


		}

		/*public void LoadJson()
		{
			using (StreamReader r = new StreamReader("file.json"))
			{
				String json = r.ReadToEnd();
				List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
			}
		}*/			
	//}
//}

