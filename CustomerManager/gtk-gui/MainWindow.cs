
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action DateiAction;
	private global::Gtk.Action dialogErrorAction;
	private global::Gtk.Action DateiAction1;
	private global::Gtk.Action noAction;
	private global::Gtk.Action DateiAction2;
	private global::Gtk.Action KundenAction;
	private global::Gtk.Action EinstellungenAction;
	private global::Gtk.Action HilfeAction;
	private global::Gtk.Action addCustomer;
	private global::Gtk.Action justifyCenterAction;
	private global::Gtk.Action addAction1;
	private global::Gtk.Action openAction;
	private global::Gtk.Action NeuerLieferantAction;
	private global::Gtk.Action LiferantenAction;
	private global::Gtk.Action addSupplier;
	private global::Gtk.Action justifyCenterAction1;
	private global::Gtk.Action openAction1;
	private global::Gtk.Action saveAction;
	private global::Gtk.Action removeAction;
	private global::Gtk.VBox vbox3;
	private global::Gtk.MenuBar menubar1;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Toolbar toolbar1;
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Fixed fixed2;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.TextView textview1;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.DateiAction = new global::Gtk.Action ("DateiAction", global::Mono.Unix.Catalog.GetString ("Datei"), null, null);
		this.DateiAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Datei");
		w1.Add (this.DateiAction, null);
		this.dialogErrorAction = new global::Gtk.Action ("dialogErrorAction", global::Mono.Unix.Catalog.GetString ("Einfügen"), null, "gtk-dialog-error");
		this.dialogErrorAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Einfügen");
		w1.Add (this.dialogErrorAction, null);
		this.DateiAction1 = new global::Gtk.Action ("DateiAction1", global::Mono.Unix.Catalog.GetString ("Datei"), null, null);
		this.DateiAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("Datei");
		w1.Add (this.DateiAction1, null);
		this.noAction = new global::Gtk.Action ("noAction", global::Mono.Unix.Catalog.GetString ("_Nein"), null, "gtk-no");
		this.noAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Nein");
		w1.Add (this.noAction, null);
		this.DateiAction2 = new global::Gtk.Action ("DateiAction2", global::Mono.Unix.Catalog.GetString ("Datei"), null, null);
		this.DateiAction2.ShortLabel = global::Mono.Unix.Catalog.GetString ("Datei");
		w1.Add (this.DateiAction2, null);
		this.KundenAction = new global::Gtk.Action ("KundenAction", global::Mono.Unix.Catalog.GetString ("Kunden"), null, null);
		this.KundenAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Kunden");
		w1.Add (this.KundenAction, null);
		this.EinstellungenAction = new global::Gtk.Action ("EinstellungenAction", global::Mono.Unix.Catalog.GetString ("Einstellungen"), null, null);
		this.EinstellungenAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Einstellungen");
		w1.Add (this.EinstellungenAction, null);
		this.HilfeAction = new global::Gtk.Action ("HilfeAction", global::Mono.Unix.Catalog.GetString ("Hilfe"), null, null);
		this.HilfeAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Hilfe");
		w1.Add (this.HilfeAction, null);
		this.addCustomer = new global::Gtk.Action ("addCustomer", global::Mono.Unix.Catalog.GetString ("Neu"), null, "gtk-add");
		this.addCustomer.ShortLabel = global::Mono.Unix.Catalog.GetString ("Neu");
		w1.Add (this.addCustomer, null);
		this.justifyCenterAction = new global::Gtk.Action ("justifyCenterAction", global::Mono.Unix.Catalog.GetString ("Anzeigen"), null, "gtk-justify-center");
		this.justifyCenterAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Anzeigen");
		w1.Add (this.justifyCenterAction, null);
		this.addAction1 = new global::Gtk.Action ("addAction1", global::Mono.Unix.Catalog.GetString ("Hinzufügen"), null, "gtk-add");
		this.addAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("Hinzufügen");
		w1.Add (this.addAction1, null);
		this.openAction = new global::Gtk.Action ("openAction", global::Mono.Unix.Catalog.GetString ("Projekt öffnen"), null, "gtk-open");
		this.openAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Projekt öffnen");
		w1.Add (this.openAction, null);
		this.NeuerLieferantAction = new global::Gtk.Action ("NeuerLieferantAction", global::Mono.Unix.Catalog.GetString ("Neuer Lieferant"), null, "Lieferant");
		this.NeuerLieferantAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Neuer Lieferant");
		w1.Add (this.NeuerLieferantAction, null);
		this.LiferantenAction = new global::Gtk.Action ("LiferantenAction", global::Mono.Unix.Catalog.GetString ("Liferanten"), null, null);
		this.LiferantenAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Liferanten");
		w1.Add (this.LiferantenAction, null);
		this.addSupplier = new global::Gtk.Action ("addSupplier", global::Mono.Unix.Catalog.GetString ("Anlegen"), null, "Lieferant");
		this.addSupplier.ShortLabel = global::Mono.Unix.Catalog.GetString ("Anlegen");
		w1.Add (this.addSupplier, null);
		this.justifyCenterAction1 = new global::Gtk.Action ("justifyCenterAction1", global::Mono.Unix.Catalog.GetString ("_Zentrieren"), null, "gtk-justify-center");
		this.justifyCenterAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Zentrieren");
		w1.Add (this.justifyCenterAction1, null);
		this.openAction1 = new global::Gtk.Action ("openAction1", global::Mono.Unix.Catalog.GetString ("Ö_ffnen"), null, "gtk-open");
		this.openAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("Ö_ffnen");
		w1.Add (this.openAction1, null);
		this.saveAction = new global::Gtk.Action ("saveAction", global::Mono.Unix.Catalog.GetString ("_Speichern"), null, "gtk-save");
		this.saveAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Speichern");
		w1.Add (this.saveAction, null);
		this.removeAction = new global::Gtk.Action ("removeAction", global::Mono.Unix.Catalog.GetString ("löschen"), null, "gtk-remove");
		this.removeAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("löschen");
		w1.Add (this.removeAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu name='DateiAction2' action='DateiAction2'><menuitem name='openAction1' action='openAction1'/><menuitem name='saveAction' action='saveAction'/></menu><menu name='KundenAction' action='KundenAction'><menuitem name='addCustomer' action='addCustomer'/><menuitem name='removeAction' action='removeAction'/><menuitem name='justifyCenterAction' action='justifyCenterAction'/></menu><menu name='LiferantenAction' action='LiferantenAction'><menuitem name='addSupplier' action='addSupplier'/><menuitem name='justifyCenterAction1' action='justifyCenterAction1'/></menu><menu name='EinstellungenAction' action='EinstellungenAction'/><menu name='HilfeAction' action='HilfeAction'/></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox3.Add (this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><toolbar name='toolbar1'><toolitem name='addAction1' action='addAction1'/><toolitem name='openAction' action='openAction'/><toolitem name='NeuerLieferantAction' action='NeuerLieferantAction'/></toolbar></ui>");
		this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar1")));
		this.toolbar1.Name = "toolbar1";
		this.toolbar1.ShowArrow = false;
		this.hbox1.Add (this.toolbar1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.toolbar1]));
		w3.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		this.hbox1.Add (this.fixed1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.fixed1]));
		w4.Position = 1;
		// Container child hbox1.Gtk.Box+BoxChild
		this.fixed2 = new global::Gtk.Fixed ();
		this.fixed2.Name = "fixed2";
		this.fixed2.HasWindow = false;
		this.hbox1.Add (this.fixed2);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.fixed2]));
		w5.Position = 2;
		this.vbox3.Add (this.hbox1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox1]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview1 = new global::Gtk.TextView ();
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.GtkScrolledWindow.Add (this.textview1);
		this.vbox3.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.GtkScrolledWindow]));
		w8.Position = 2;
		this.Add (this.vbox3);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 692;
		this.DefaultHeight = 344;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.addCustomer.Activated += new global::System.EventHandler (this.OnAddCustomerActivated);
		this.addSupplier.Activated += new global::System.EventHandler (this.OnAddSupplierActivated);
	}
}
