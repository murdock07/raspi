
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	
	private global::Gtk.Action SettingsAction;
	
	private global::Gtk.Action CloseAction;
	
	private global::Gtk.Action ViewStatusAction;
	
	private global::Gtk.Action ConfigureAction;
	
	private global::Gtk.Fixed MainContainer;
	
	private global::Gtk.MenuBar MainMenubar;
	
	private global::Gtk.Button ButtonSend;
	
	private global::Gtk.Button ButtonClear;
	
	private global::Gtk.Entry entry2;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.SettingsAction = new global::Gtk.Action ("SettingsAction", global::Mono.Unix.Catalog.GetString ("Settings"), null, null);
		this.SettingsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Settings");
		w1.Add (this.SettingsAction, null);
		this.CloseAction = new global::Gtk.Action ("CloseAction", global::Mono.Unix.Catalog.GetString ("Close"), null, null);
		this.CloseAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Close");
		w1.Add (this.CloseAction, null);
		this.ViewStatusAction = new global::Gtk.Action ("ViewStatusAction", global::Mono.Unix.Catalog.GetString ("View Status"), null, null);
		this.ViewStatusAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("View Status");
		w1.Add (this.ViewStatusAction, null);
		this.ConfigureAction = new global::Gtk.Action ("ConfigureAction", global::Mono.Unix.Catalog.GetString ("Configure"), null, null);
		this.ConfigureAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Configure");
		w1.Add (this.ConfigureAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.Resizable = false;
		this.AllowGrow = false;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.MainContainer = new global::Gtk.Fixed ();
		this.MainContainer.Name = "MainContainer";
		this.MainContainer.HasWindow = false;
		// Container child MainContainer.Gtk.Fixed+FixedChild
		this.UIManager.AddUiFromString (@"<ui><menubar name='MainMenubar'><menu name='SettingsAction' action='SettingsAction'><menuitem name='ViewStatusAction' action='ViewStatusAction'/><menuitem name='ConfigureAction' action='ConfigureAction'/></menu><menu name='CloseAction' action='CloseAction'/></menubar></ui>");
		this.MainMenubar = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/MainMenubar")));
		this.MainMenubar.Name = "MainMenubar";
		this.MainContainer.Add (this.MainMenubar);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.MainContainer [this.MainMenubar]));
		w2.X = 1;
		w2.Y = 1;
		// Container child MainContainer.Gtk.Fixed+FixedChild
		this.ButtonSend = new global::Gtk.Button ();
		this.ButtonSend.CanFocus = true;
		this.ButtonSend.Name = "ButtonSend";
		this.ButtonSend.UseUnderline = true;
		this.ButtonSend.Label = global::Mono.Unix.Catalog.GetString ("Send");
		this.MainContainer.Add (this.ButtonSend);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.MainContainer [this.ButtonSend]));
		w3.X = 1;
		w3.Y = 237;
		// Container child MainContainer.Gtk.Fixed+FixedChild
		this.ButtonClear = new global::Gtk.Button ();
		this.ButtonClear.CanFocus = true;
		this.ButtonClear.Name = "ButtonClear";
		this.ButtonClear.UseUnderline = true;
		this.ButtonClear.Label = global::Mono.Unix.Catalog.GetString ("Clear");
		this.MainContainer.Add (this.ButtonClear);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.MainContainer [this.ButtonClear]));
		w4.X = 40;
		w4.Y = 237;
		// Container child MainContainer.Gtk.Fixed+FixedChild
		this.entry2 = new global::Gtk.Entry ();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '●';
		this.MainContainer.Add (this.entry2);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.MainContainer [this.entry2]));
		w5.X = 1;
		w5.Y = 30;
		this.Add (this.MainContainer);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 425;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		//this.CloseAction.Activated += new global::System.EventHandler (this.OnCloseActionActivated);
		this.ViewStatusAction.Activated += new global::System.EventHandler (this.OnViewStatusActionActivated);
		this.ConfigureAction.Activated += new global::System.EventHandler (this.OnConfigureActionActivated);
		this.ButtonSend.Clicked += new global::System.EventHandler (this.OnButtonSendClicked);
		this.ButtonClear.Clicked += new global::System.EventHandler (this.OnButtonClearClicked);
	}
}
