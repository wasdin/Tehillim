using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Tehillim
{
	public class ScottishMetricalVersion
	{
		RootObject psalter;

		public ScottishMetricalVersion ()
		{
			RootObject tempObject = null;
			using (StreamReader file = File.OpenText("../../smv1650.json")) {
				JsonSerializer serializer = new JsonSerializer ();
				tempObject = (RootObject)serializer.Deserialize (file, typeof(RootObject));
			}

			psalter = tempObject;
		}

		public String getPsalm (int number)
		{
			for (int i=0; i<psalter.Books[0].Chapters.Count; i++) {
				String chapterString = psalter.Books[0].Chapters[i].Name.ToString();
				String chapter = Regex.Replace(chapterString, @"\D", "");
				int chapterNumber = int.Parse(chapter);
				if (chapterNumber == number) {
					return psalter.Books[0].Chapters[i].ToString ();
				}
			}
			return "";
		}


	}
}

