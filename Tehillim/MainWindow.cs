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
		about.Version = "0.2";
		about.Comments = "The 1650 Scottish Metrical Psalter";
		about.Website = "https://github.com/wasdin/Tehillim";
		about.Run ();
		about.Destroy();
	}	
		
	protected void selectPsalm1 (object sender, EventArgs e)
	{
		ScottishMetricalVersion SMV_builder = new ScottishMetricalVersion();
		AuthorisedVersion AV_builder = new AuthorisedVersion ();

		String versionSelected = translationSelector1.ActiveText;
		int selected = Convert.ToInt32(psalmNumberSelected1.Value);
		psalmViewingSpace1.Buffer.SetText ("Psalm " + selected);

		if (versionSelected.StartsWith("1769")) {
			psalmViewingSpace1.Buffer.SetText (AV_builder.getPsalm(selected));
		}
		else if (versionSelected.StartsWith("1650")) {
			psalmViewingSpace1.Buffer.SetText (SMV_builder.getPsalm(selected));
		}
			
	}

	protected void selectPsalm2 (object sender, EventArgs e)
	{
		ScottishMetricalVersion SMV_builder = new ScottishMetricalVersion();
		AuthorisedVersion AV_builder = new AuthorisedVersion ();

		String versionSelected = translationSelector2.ActiveText;
		int selected = Convert.ToInt32(psalmNumberSelected2.Value);
		psalmViewingSpace2.Buffer.SetText ("Psalm " + selected);

		if (versionSelected.StartsWith("1769")) {
			psalmViewingSpace2.Buffer.SetText (AV_builder.getPsalm(selected));
		}
		else if (versionSelected.StartsWith("1650")) {
			psalmViewingSpace2.Buffer.SetText (SMV_builder.getPsalm(selected));
		}
	}
}
