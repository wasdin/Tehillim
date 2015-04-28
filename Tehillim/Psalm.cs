using System;
using System.Collections.Generic;

namespace Tehillim
{
	public class Psalm
	{
		int number;
		String name;
		List<String> verses;
		Meter meter;


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

	}
}

