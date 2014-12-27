using System;
using Gtk;
using Raspi;

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
		
	//Button handling
	protected void OnButtonClearClicked (object sender, EventArgs e)
	{
		MessagingClass.ClearHistory();	
	}
	protected void OnButtonSendClicked (object sender, EventArgs e)
	{
		string messageContent = "";
		MessagingClass.SendMessage(messageContent);
	}
	//Menu handling
	protected void OnConfigureActionActivated (object sender, EventArgs e)
	{

	}
	protected void OnViewStatusActionActivated (object sender, EventArgs e)
	{

	}
}