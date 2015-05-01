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
		about.Version = "0.1";
		about.Comments = "The 1650 Scottish Metrical Psalter";
		about.Website = "https://bitbucket.org/jakewasdin/tehillim/";
		about.Run ();
		about.Destroy();
	}	
	protected void psalmSelect (object sender, EventArgs e)
	{
		int selected = Convert.ToInt32(psalmNumberSelected.Value);
		psalmViewingSpace.Buffer.SetText ("Psalm " + selected);

		ScottishMetricalVersion builder = new ScottishMetricalVersion();


		psalmViewingSpace.Buffer.SetText (builder.getPsalm(selected));
	}
}
