using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void ClickedHandler (object sender, EventArgs e)
	{
        var dlg = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, $"message");
		dlg.Show ();
	}
}
