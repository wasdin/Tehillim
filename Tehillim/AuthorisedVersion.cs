using System;
using System.IO;
using System.Collections.Generic;


namespace Tehillim
{
	public class AuthorisedVersion
	{
		String[] lines = System.IO.File.ReadAllLines ("../../kjv1769.txt");

		public AuthorisedVersion ()
		{


			/*foreach (String line in lines) {
				if (line.StartsWith("Psalm ")) {
					Console.WriteLine (line);
				}
			}*/


		}

		public String getPsalm (int number) {
			int start = 0;
			int end = 0;
			for (int i = 0; i < lines.Length; i++) {
				String checkString = "Psalm " + number + "";
				if (lines [i].Equals (checkString)) {
					start = i;
					for (int j = i+1; j < lines.Length; j++) {
						if (lines [j].StartsWith ("Psalm ")) {
							end = j;
							break;
						}
					}
				}
			}

			String output = "";
			for (int i = start; i < end; i++) {
				output += "\n" + lines [i];
			}
			return output;
		}

	}
}

