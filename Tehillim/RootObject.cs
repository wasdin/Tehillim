// This receives the JSON

using System;
using System.Collections.Generic;

namespace Tehillim
{
	public class Vers
	{
	    public int Enum { get; set; }
	    public string Html { get; set; }
	}

	public class Paragraph
	{
	    public int Enum { get; set; }
	    public List<Vers> Verses { get; set; }
	}

	public class Chapter
	{
	    public int Enum { get; set; }
	    public string Name { get; set; }
	    public List<Paragraph> Paragraphs { get; set; }

			public override string ToString ()
			{
				String output = "";
				output += Name;
				for (int i=0; i<Paragraphs.Count; i++) {
					output += "\n";
					for (int j=0; j<Paragraphs[i].Verses.Count; j++) {
						output += "\n" + Paragraphs[i].Verses[j].Html;
					}
				}

				return output;
			}

	}

	public class Book
	{
	    public int Enum { get; set; }
	    public string Name { get; set; }
	    public List<Chapter> Chapters { get; set; }
	}

	public class RootObject
	{
	    public int Type { get; set; }
	    public string Name { get; set; }
	    public string Author { get; set; }
	    public object Copyright { get; set; }
	    public string ResId { get; set; }
	    public List<Book> Books { get; set; }
	    public object TableOfContents { get; set; }

	}
}

