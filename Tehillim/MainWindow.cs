using System;
using Gtk;
using Tehillim;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();


	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	protected void about (object sender, EventArgs e)
	{
		AboutDialog about = new AboutDialog();
		about.ProgramName = "Tehillim";
		about.Version = "1.0";
		about.Run ();
		about.Destroy();
	}	
	protected void psalmSelect (object sender, EventArgs e)
	{

		var selected = psalmNumberSelected.Value;
		psalmViewingSpace.Buffer.SetText ("Psalm " + selected);
		Console.WriteLine (selected);

		Psalm[] psalms = new Psalm[150];
		psalms [117] = new Psalm (117, "Psalm 117", Tehillim.Meter.CommonMeter);
		psalms [117].verses.Add ("O give ye praise unto the Lord, \n\tall nations that be; \nLikewise, ye people all, accord \n\this name to magnify.");
		psalms [117].verses.Add ("\nFor great to us-ward ever are \n\this loving-kindnesses: \nHis truth endures for evermore. \n\tThe Lord O do ye bless.");

		String output = psalms[117].ToString();

		psalmViewingSpace.Buffer.SetText (output);

	
	}
}
