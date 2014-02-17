
// This file has been generated by the GUI designer. Do not modify.
namespace CustomerManager
{
	public partial class SupplierWindow
	{
		private global::Gtk.UIManager UIManager;
		private global::Gtk.Action applyAction;
		private global::Gtk.Action closeAction;
		private global::Gtk.Action clearAction;
		private global::Gtk.Action dialogQuestionAction;
		private global::Gtk.Action applyAction1;
		private global::Gtk.Action closeAction1;
		private global::Gtk.Action clearAction1;
		private global::Gtk.Action dialogQuestionAction1;
		private global::Gtk.VBox vbox1;
		private global::Gtk.Toolbar toolbar2;
		private global::Gtk.Label supplierDataLabel;
		private global::Gtk.HSeparator hseparator6;
		private global::Gtk.Table table3;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget CustomerManager.SupplierWindow
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.applyAction = new global::Gtk.Action ("applyAction", null, null, "gtk-apply");
			w1.Add (this.applyAction, null);
			this.closeAction = new global::Gtk.Action ("closeAction", null, null, "gtk-close");
			w1.Add (this.closeAction, null);
			this.clearAction = new global::Gtk.Action ("clearAction", null, null, "gtk-clear");
			w1.Add (this.clearAction, null);
			this.dialogQuestionAction = new global::Gtk.Action ("dialogQuestionAction", null, null, "gtk-dialog-question");
			w1.Add (this.dialogQuestionAction, null);
			this.applyAction1 = new global::Gtk.Action ("applyAction1", null, null, "gtk-apply");
			w1.Add (this.applyAction1, null);
			this.closeAction1 = new global::Gtk.Action ("closeAction1", null, null, "gtk-close");
			w1.Add (this.closeAction1, null);
			this.clearAction1 = new global::Gtk.Action ("clearAction1", null, null, "gtk-clear");
			w1.Add (this.clearAction1, null);
			this.dialogQuestionAction1 = new global::Gtk.Action ("dialogQuestionAction1", null, null, "gtk-dialog-question");
			w1.Add (this.dialogQuestionAction1, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "CustomerManager.SupplierWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("SupplierWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child CustomerManager.SupplierWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString (@"<ui><toolbar name='toolbar2'><toolitem name='applyAction' action='applyAction'/><toolitem name='closeAction' action='closeAction'/><separator/><toolitem name='clearAction' action='clearAction'/><toolitem name='dialogQuestionAction' action='dialogQuestionAction'/></toolbar></ui>");
			this.toolbar2 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar2")));
			this.toolbar2.Name = "toolbar2";
			this.toolbar2.ShowArrow = false;
			this.vbox1.Add (this.toolbar2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.toolbar2]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.supplierDataLabel = new global::Gtk.Label ();
			this.supplierDataLabel.Name = "supplierDataLabel";
			this.supplierDataLabel.Xalign = 0F;
			this.supplierDataLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Lieferantendaten");
			this.vbox1.Add (this.supplierDataLabel);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.supplierDataLabel]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparator6 = new global::Gtk.HSeparator ();
			this.hseparator6.Name = "hseparator6";
			this.vbox1.Add (this.hseparator6);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hseparator6]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table (((uint)(3)), ((uint)(3)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			this.vbox1.Add (this.table3);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table3]));
			w5.Position = 3;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 679;
			this.DefaultHeight = 506;
			this.Show ();
		}
	}
}
