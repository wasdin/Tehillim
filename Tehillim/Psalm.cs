using System;

namespace Tehillim
{
	public class Psalm
	{
		int number;
		String name;
		List verses;
		Meter meter;


		public Psalm (int number, String name, List verses, Meter meter)
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
			verses = new List();
			this.meter = meter;
		}

	}
}

