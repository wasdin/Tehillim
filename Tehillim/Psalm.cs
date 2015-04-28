using System;
using System.Collections.Generic;

namespace Tehillim
{
	public class Psalm
	{
		public int number;
		public String name;
		public List<String> verses;
		public Meter meter;


		public Psalm (int number, String name, List<String> verses, Meter meter)
		{
			this.number = number;
			this.name = name;
			this.verses = verses;
			this.meter = meter;
		}

		public Psalm (int number, String name, Meter meter)
		{
			this.number = number;
			this.name = name;
			verses = new List<String>();
			this.meter = meter;
		}

		public override String ToString ()
		{
			String output = "";
			output += name;
			for (int i=0; i<verses.Count; i++) {
				output += "\n" + verses[i];
			}
			return output;
		}


	}
}

