using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tehillim
{
	public class SMV_Builder
	{
		RootObject psalter;

		public SMV_Builder ()
		{
			RootObject tempObject = null;
			using (StreamReader file = File.OpenText("../../smv_1650.json")) {
				JsonSerializer serializer = new JsonSerializer ();
				tempObject = (RootObject)serializer.Deserialize (file, typeof(RootObject));
			}

			psalter = tempObject;
		}

		public String getPsalm (int number)
		{
			for (int i=0; i<psalter.Books[0].Chapters.Count; i++) {
				int chapter = psalter.Books[0].Chapters[i];
			}
		}


	}
}

