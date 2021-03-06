
// This file has been generated by the GUI designer. Do not modify.
namespace CustomerManager
{
	public partial class CustomerWindow
	{
		private global::Gtk.UIManager UIManager;
		private global::Gtk.Action applyAction;
		private global::Gtk.Action closeAction;
		private global::Gtk.Action clearAction;
		private global::Gtk.Action dialogQuestionAction;
		private global::Gtk.Action newCustomer;
		private global::Gtk.Action closeTB;
		private global::Gtk.Action clearTB;
		private global::Gtk.Action dialogQuestionTB;
		private global::Gtk.VBox vbox1;
		private global::Gtk.Toolbar toolbar2;
		private global::Gtk.Fixed headerFixed;
		private global::Gtk.Label headerLabel;
		private global::Gtk.HSeparator hseparator1;
		private global::Gtk.Table table1;
		private global::Gtk.Label emailLabel;
		private global::Gtk.Entry emailTextBox;
		private global::Gtk.ComboBox genderCB;
		private global::Gtk.Label genderLabel;
		private global::Gtk.HBox hbox1;
		private global::Gtk.ComboBox companyCB;
		private global::Gtk.Button newCompanyButton;
		private global::Gtk.Label hnrLabel;
		private global::Gtk.Entry hnrTextBox;
		private global::Gtk.Label mobileLabel;
		private global::Gtk.Entry mobileTextBox;
		private global::Gtk.Label nnameLabel;
		private global::Gtk.Entry nnameTextBox;
		private global::Gtk.Entry phoneTextBox;
		private global::Gtk.Label plzLabel;
		private global::Gtk.Entry plzTextBox;
		private global::Gtk.Label streetLabel;
		private global::Gtk.Entry streetTextBox;
		private global::Gtk.Label telephoneLabel;
		private global::Gtk.ComboBox typCB;
		private global::Gtk.Label typLabel;
		private global::Gtk.Label villageLabel;
		private global::Gtk.Entry villageTextBox;
		private global::Gtk.Label vnameLabel;
		private global::Gtk.Entry vnameTextBox;
		private global::Gtk.Label warningLabel;
		private global::Gtk.Fixed fixed1;
		private global::Gtk.Label userdataLabel;
		private global::Gtk.HSeparator hseparator2;
		private global::Gtk.Table newUserTable;
		private global::Gtk.Entry pwCTextBox;
		private global::Gtk.Label pwdCLabel;
		private global::Gtk.Image pwdCPictureBox;
		private global::Gtk.Label pwdLabel;
		private global::Gtk.Image pwPictureBox;
		private global::Gtk.Entry pwTextBox;
		private global::Gtk.Label unameLabel;
		private global::Gtk.Entry usernameTextBox;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget CustomerManager.CustomerWindow
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.applyAction = new global::Gtk.Action ("applyAction", global::Mono.Unix.Catalog.GetString ("bestätigen"), null, "gtk-apply");
			this.applyAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("bestätigen");
			w1.Add (this.applyAction, null);
			this.closeAction = new global::Gtk.Action ("closeAction", global::Mono.Unix.Catalog.GetString ("abbrechen"), global::Mono.Unix.Catalog.GetString ("Fenster wird geschlossen"), "gtk-close");
			this.closeAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("abbrechen");
			w1.Add (this.closeAction, null);
			this.clearAction = new global::Gtk.Action ("clearAction", global::Mono.Unix.Catalog.GetString ("leeren"), global::Mono.Unix.Catalog.GetString ("alle Eintragungen werden gelöscht"), "gtk-clear");
			this.clearAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("leeren");
			w1.Add (this.clearAction, null);
			this.dialogQuestionAction = new global::Gtk.Action ("dialogQuestionAction", global::Mono.Unix.Catalog.GetString ("Hilfe"), global::Mono.Unix.Catalog.GetString ("Hilfe anzeigen"), "gtk-dialog-question");
			this.dialogQuestionAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Hilfe");
			w1.Add (this.dialogQuestionAction, null);
			this.newCustomer = new global::Gtk.Action ("newCustomer", global::Mono.Unix.Catalog.GetString ("bestätigen"), null, "gtk-apply");
			this.newCustomer.ShortLabel = global::Mono.Unix.Catalog.GetString ("bestätigen");
			w1.Add (this.newCustomer, null);
			this.closeTB = new global::Gtk.Action ("closeTB", global::Mono.Unix.Catalog.GetString ("abbrechen"), global::Mono.Unix.Catalog.GetString ("alles abbrechen und Fenster schließen"), "gtk-close");
			this.closeTB.ShortLabel = global::Mono.Unix.Catalog.GetString ("abbrechen");
			w1.Add (this.closeTB, null);
			this.clearTB = new global::Gtk.Action ("clearTB", global::Mono.Unix.Catalog.GetString ("leeren"), global::Mono.Unix.Catalog.GetString ("alle Eintragungen löschen"), "gtk-clear");
			this.clearTB.ShortLabel = global::Mono.Unix.Catalog.GetString ("leeren");
			w1.Add (this.clearTB, null);
			this.dialogQuestionTB = new global::Gtk.Action ("dialogQuestionTB", global::Mono.Unix.Catalog.GetString ("Hilfe"), null, "gtk-dialog-question");
			this.dialogQuestionTB.ShortLabel = global::Mono.Unix.Catalog.GetString ("Hilfe");
			w1.Add (this.dialogQuestionTB, null);
			this.UIManager.InsertActionGroup (w1, 0);
			global::Gtk.ActionGroup w2 = new global::Gtk.ActionGroup ("Default");
			this.UIManager.InsertActionGroup (w2, 1);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "CustomerManager.CustomerWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("neuer Benutzer");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.BorderWidth = ((uint)(9));
			// Container child CustomerManager.CustomerWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><toolbar name='toolbar2'><toolitem name='newCustomer' action='newCustomer'/><toolitem name='closeTB' action='closeTB'/><separator/><toolitem name='clearTB' action='clearTB'/><toolitem name='dialogQuestionTB' action='dialogQuestionTB'/></toolbar></ui>");
			this.toolbar2 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar2")));
			this.toolbar2.Name = "toolbar2";
			this.toolbar2.ShowArrow = false;
			this.vbox1.Add (this.toolbar2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.toolbar2]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.headerFixed = new global::Gtk.Fixed ();
			this.headerFixed.HeightRequest = 30;
			this.headerFixed.Name = "headerFixed";
			this.headerFixed.HasWindow = false;
			// Container child headerFixed.Gtk.Fixed+FixedChild
			this.headerLabel = new global::Gtk.Label ();
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Xalign = 0F;
			this.headerLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Neuer Kunde erstellen");
			this.headerLabel.UseMarkup = true;
			this.headerLabel.UseUnderline = true;
			this.headerFixed.Add (this.headerLabel);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.headerFixed [this.headerLabel]));
			w4.X = 2;
			w4.Y = 12;
			this.vbox1.Add (this.headerFixed);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.headerFixed]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox1.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hseparator1]));
			w6.Position = 2;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(11)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.emailLabel = new global::Gtk.Label ();
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Xalign = 0F;
			this.emailLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Email: ");
			this.table1.Add (this.emailLabel);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.emailLabel]));
			w7.TopAttach = ((uint)(4));
			w7.BottomAttach = ((uint)(5));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.emailTextBox = new global::Gtk.Entry ();
			this.emailTextBox.CanFocus = true;
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.IsEditable = true;
			this.emailTextBox.InvisibleChar = '●';
			this.table1.Add (this.emailTextBox);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.emailTextBox]));
			w8.TopAttach = ((uint)(4));
			w8.BottomAttach = ((uint)(5));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.genderCB = global::Gtk.ComboBox.NewText ();
			this.genderCB.AppendText (global::Mono.Unix.Catalog.GetString ("Herr"));
			this.genderCB.AppendText (global::Mono.Unix.Catalog.GetString ("Frau"));
			this.genderCB.Name = "genderCB";
			this.genderCB.Active = 0;
			this.table1.Add (this.genderCB);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.genderCB]));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.genderLabel = new global::Gtk.Label ();
			this.genderLabel.Name = "genderLabel";
			this.genderLabel.Xalign = 0F;
			this.genderLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Anrede: ");
			this.table1.Add (this.genderLabel);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.genderLabel]));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.companyCB = global::Gtk.ComboBox.NewText ();
			this.companyCB.WidthRequest = 200;
			this.companyCB.Name = "companyCB";
			this.hbox1.Add (this.companyCB);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.companyCB]));
			w11.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.newCompanyButton = new global::Gtk.Button ();
			this.newCompanyButton.CanFocus = true;
			this.newCompanyButton.Name = "newCompanyButton";
			this.newCompanyButton.UseUnderline = true;
			// Container child newCompanyButton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w12 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w13 = new global::Gtk.HBox ();
			w13.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w14 = new global::Gtk.Image ();
			w14.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "stock_new-bcard", global::Gtk.IconSize.Button);
			w13.Add (w14);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w16 = new global::Gtk.Label ();
			w16.LabelProp = global::Mono.Unix.Catalog.GetString ("Firma hinzufügen");
			w16.UseUnderline = true;
			w13.Add (w16);
			w12.Add (w13);
			this.newCompanyButton.Add (w12);
			this.hbox1.Add (this.newCompanyButton);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.newCompanyButton]));
			w20.Position = 1;
			this.table1.Add (this.hbox1);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox1]));
			w21.TopAttach = ((uint)(3));
			w21.BottomAttach = ((uint)(4));
			w21.LeftAttach = ((uint)(2));
			w21.RightAttach = ((uint)(3));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hnrLabel = new global::Gtk.Label ();
			this.hnrLabel.Name = "hnrLabel";
			this.hnrLabel.Xalign = 0F;
			this.hnrLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Hausnummer:");
			this.table1.Add (this.hnrLabel);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1 [this.hnrLabel]));
			w22.TopAttach = ((uint)(10));
			w22.BottomAttach = ((uint)(11));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hnrTextBox = new global::Gtk.Entry ();
			this.hnrTextBox.CanFocus = true;
			this.hnrTextBox.Name = "hnrTextBox";
			this.hnrTextBox.IsEditable = true;
			this.hnrTextBox.InvisibleChar = '●';
			this.table1.Add (this.hnrTextBox);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1 [this.hnrTextBox]));
			w23.TopAttach = ((uint)(10));
			w23.BottomAttach = ((uint)(11));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(2));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.mobileLabel = new global::Gtk.Label ();
			this.mobileLabel.Name = "mobileLabel";
			this.mobileLabel.Xalign = 0F;
			this.mobileLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Mobil: ");
			this.table1.Add (this.mobileLabel);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1 [this.mobileLabel]));
			w24.TopAttach = ((uint)(6));
			w24.BottomAttach = ((uint)(7));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.mobileTextBox = new global::Gtk.Entry ();
			this.mobileTextBox.CanFocus = true;
			this.mobileTextBox.Name = "mobileTextBox";
			this.mobileTextBox.IsEditable = true;
			this.mobileTextBox.InvisibleChar = '●';
			this.table1.Add (this.mobileTextBox);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1 [this.mobileTextBox]));
			w25.TopAttach = ((uint)(6));
			w25.BottomAttach = ((uint)(7));
			w25.LeftAttach = ((uint)(1));
			w25.RightAttach = ((uint)(2));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.nnameLabel = new global::Gtk.Label ();
			this.nnameLabel.Name = "nnameLabel";
			this.nnameLabel.Xalign = 0F;
			this.nnameLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Nachname: ");
			this.table1.Add (this.nnameLabel);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table1 [this.nnameLabel]));
			w26.TopAttach = ((uint)(1));
			w26.BottomAttach = ((uint)(2));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.nnameTextBox = new global::Gtk.Entry ();
			this.nnameTextBox.CanFocus = true;
			this.nnameTextBox.Name = "nnameTextBox";
			this.nnameTextBox.IsEditable = true;
			this.nnameTextBox.InvisibleChar = '●';
			this.table1.Add (this.nnameTextBox);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table1 [this.nnameTextBox]));
			w27.TopAttach = ((uint)(1));
			w27.BottomAttach = ((uint)(2));
			w27.LeftAttach = ((uint)(1));
			w27.RightAttach = ((uint)(2));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.phoneTextBox = new global::Gtk.Entry ();
			this.phoneTextBox.CanFocus = true;
			this.phoneTextBox.Name = "phoneTextBox";
			this.phoneTextBox.IsEditable = true;
			this.phoneTextBox.InvisibleChar = '●';
			this.table1.Add (this.phoneTextBox);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table1 [this.phoneTextBox]));
			w28.TopAttach = ((uint)(5));
			w28.BottomAttach = ((uint)(6));
			w28.LeftAttach = ((uint)(1));
			w28.RightAttach = ((uint)(2));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.plzLabel = new global::Gtk.Label ();
			this.plzLabel.Name = "plzLabel";
			this.plzLabel.Xalign = 0F;
			this.plzLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("PLZ:");
			this.table1.Add (this.plzLabel);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table1 [this.plzLabel]));
			w29.TopAttach = ((uint)(7));
			w29.BottomAttach = ((uint)(8));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.plzTextBox = new global::Gtk.Entry ();
			this.plzTextBox.CanFocus = true;
			this.plzTextBox.Name = "plzTextBox";
			this.plzTextBox.IsEditable = true;
			this.plzTextBox.InvisibleChar = '●';
			this.table1.Add (this.plzTextBox);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table1 [this.plzTextBox]));
			w30.TopAttach = ((uint)(7));
			w30.BottomAttach = ((uint)(8));
			w30.LeftAttach = ((uint)(1));
			w30.RightAttach = ((uint)(2));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.streetLabel = new global::Gtk.Label ();
			this.streetLabel.Name = "streetLabel";
			this.streetLabel.Xalign = 0F;
			this.streetLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Straße:");
			this.table1.Add (this.streetLabel);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table1 [this.streetLabel]));
			w31.TopAttach = ((uint)(9));
			w31.BottomAttach = ((uint)(10));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.streetTextBox = new global::Gtk.Entry ();
			this.streetTextBox.CanFocus = true;
			this.streetTextBox.Name = "streetTextBox";
			this.streetTextBox.IsEditable = true;
			this.streetTextBox.InvisibleChar = '●';
			this.table1.Add (this.streetTextBox);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table1 [this.streetTextBox]));
			w32.TopAttach = ((uint)(9));
			w32.BottomAttach = ((uint)(10));
			w32.LeftAttach = ((uint)(1));
			w32.RightAttach = ((uint)(2));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.telephoneLabel = new global::Gtk.Label ();
			this.telephoneLabel.Name = "telephoneLabel";
			this.telephoneLabel.Xalign = 0F;
			this.telephoneLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Telefon: ");
			this.table1.Add (this.telephoneLabel);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table1 [this.telephoneLabel]));
			w33.TopAttach = ((uint)(5));
			w33.BottomAttach = ((uint)(6));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.typCB = global::Gtk.ComboBox.NewText ();
			this.typCB.AppendText (global::Mono.Unix.Catalog.GetString ("Privat"));
			this.typCB.AppendText (global::Mono.Unix.Catalog.GetString ("Firma"));
			this.typCB.AppendText (global::Mono.Unix.Catalog.GetString ("Unternehmen"));
			this.typCB.Name = "typCB";
			this.table1.Add (this.typCB);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table1 [this.typCB]));
			w34.TopAttach = ((uint)(3));
			w34.BottomAttach = ((uint)(4));
			w34.LeftAttach = ((uint)(1));
			w34.RightAttach = ((uint)(2));
			w34.XOptions = ((global::Gtk.AttachOptions)(4));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.typLabel = new global::Gtk.Label ();
			this.typLabel.Name = "typLabel";
			this.typLabel.Xalign = 0F;
			this.typLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Typ: ");
			this.table1.Add (this.typLabel);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table1 [this.typLabel]));
			w35.TopAttach = ((uint)(3));
			w35.BottomAttach = ((uint)(4));
			w35.XOptions = ((global::Gtk.AttachOptions)(4));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.villageLabel = new global::Gtk.Label ();
			this.villageLabel.Name = "villageLabel";
			this.villageLabel.Xalign = 0F;
			this.villageLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Ort:");
			this.table1.Add (this.villageLabel);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.table1 [this.villageLabel]));
			w36.TopAttach = ((uint)(8));
			w36.BottomAttach = ((uint)(9));
			w36.XOptions = ((global::Gtk.AttachOptions)(4));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.villageTextBox = new global::Gtk.Entry ();
			this.villageTextBox.CanFocus = true;
			this.villageTextBox.Name = "villageTextBox";
			this.villageTextBox.IsEditable = true;
			this.villageTextBox.InvisibleChar = '●';
			this.table1.Add (this.villageTextBox);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.table1 [this.villageTextBox]));
			w37.TopAttach = ((uint)(8));
			w37.BottomAttach = ((uint)(9));
			w37.LeftAttach = ((uint)(1));
			w37.RightAttach = ((uint)(2));
			w37.XOptions = ((global::Gtk.AttachOptions)(4));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.vnameLabel = new global::Gtk.Label ();
			this.vnameLabel.Name = "vnameLabel";
			this.vnameLabel.Xalign = 0F;
			this.vnameLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Vorname: ");
			this.table1.Add (this.vnameLabel);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.table1 [this.vnameLabel]));
			w38.TopAttach = ((uint)(2));
			w38.BottomAttach = ((uint)(3));
			w38.XOptions = ((global::Gtk.AttachOptions)(4));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.vnameTextBox = new global::Gtk.Entry ();
			this.vnameTextBox.CanFocus = true;
			this.vnameTextBox.Name = "vnameTextBox";
			this.vnameTextBox.IsEditable = true;
			this.vnameTextBox.InvisibleChar = '●';
			this.table1.Add (this.vnameTextBox);
			global::Gtk.Table.TableChild w39 = ((global::Gtk.Table.TableChild)(this.table1 [this.vnameTextBox]));
			w39.TopAttach = ((uint)(2));
			w39.BottomAttach = ((uint)(3));
			w39.LeftAttach = ((uint)(1));
			w39.RightAttach = ((uint)(2));
			w39.XOptions = ((global::Gtk.AttachOptions)(4));
			w39.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.warningLabel = new global::Gtk.Label ();
			this.warningLabel.Name = "warningLabel";
			this.warningLabel.Xalign = 0F;
			this.warningLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Bitte nur Zahlen eingeben!");
			this.table1.Add (this.warningLabel);
			global::Gtk.Table.TableChild w40 = ((global::Gtk.Table.TableChild)(this.table1 [this.warningLabel]));
			w40.TopAttach = ((uint)(7));
			w40.BottomAttach = ((uint)(8));
			w40.LeftAttach = ((uint)(2));
			w40.RightAttach = ((uint)(3));
			w40.XOptions = ((global::Gtk.AttachOptions)(4));
			w40.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add (this.table1);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table1]));
			w41.Position = 3;
			w41.Expand = false;
			w41.Fill = false;
			w41.Padding = ((uint)(14));
			// Container child vbox1.Gtk.Box+BoxChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.vbox1.Add (this.fixed1);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.fixed1]));
			w42.Position = 4;
			// Container child vbox1.Gtk.Box+BoxChild
			this.userdataLabel = new global::Gtk.Label ();
			this.userdataLabel.Name = "userdataLabel";
			this.userdataLabel.Xalign = 0F;
			this.userdataLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Benutzerdaten");
			this.vbox1.Add (this.userdataLabel);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.userdataLabel]));
			w43.Position = 5;
			w43.Expand = false;
			w43.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator ();
			this.hseparator2.Name = "hseparator2";
			this.vbox1.Add (this.hseparator2);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hseparator2]));
			w44.Position = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.newUserTable = new global::Gtk.Table (((uint)(3)), ((uint)(3)), false);
			this.newUserTable.Name = "newUserTable";
			this.newUserTable.RowSpacing = ((uint)(6));
			this.newUserTable.ColumnSpacing = ((uint)(6));
			// Container child newUserTable.Gtk.Table+TableChild
			this.pwCTextBox = new global::Gtk.Entry ();
			this.pwCTextBox.CanFocus = true;
			this.pwCTextBox.Name = "pwCTextBox";
			this.pwCTextBox.IsEditable = true;
			this.pwCTextBox.Visibility = false;
			this.pwCTextBox.InvisibleChar = '●';
			this.newUserTable.Add (this.pwCTextBox);
			global::Gtk.Table.TableChild w45 = ((global::Gtk.Table.TableChild)(this.newUserTable [this.pwCTextBox]));
			w45.TopAttach = ((uint)(2));
			w45.BottomAttach = ((uint)(3));
			w45.LeftAttach = ((uint)(1));
			w45.RightAttach = ((uint)(2));
			w45.XOptions = ((global::Gtk.AttachOptions)(4));
			w45.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child newUserTable.Gtk.Table+TableChild
			this.pwdCLabel = new global::Gtk.Label ();
			this.pwdCLabel.Name = "pwdCLabel";
			this.pwdCLabel.Xalign = 0F;
			this.pwdCLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Passwort bestätigen:");
			this.newUserTable.Add (this.pwdCLabel);
			global::Gtk.Table.TableChild w46 = ((global::Gtk.Table.TableChild)(this.newUserTable [this.pwdCLabel]));
			w46.TopAttach = ((uint)(2));
			w46.BottomAttach = ((uint)(3));
			w46.XOptions = ((global::Gtk.AttachOptions)(4));
			w46.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child newUserTable.Gtk.Table+TableChild
			this.pwdCPictureBox = new global::Gtk.Image ();
			this.pwdCPictureBox.Name = "pwdCPictureBox";
			this.newUserTable.Add (this.pwdCPictureBox);
			global::Gtk.Table.TableChild w47 = ((global::Gtk.Table.TableChild)(this.newUserTable [this.pwdCPictureBox]));
			w47.TopAttach = ((uint)(2));
			w47.BottomAttach = ((uint)(3));
			w47.LeftAttach = ((uint)(2));
			w47.RightAttach = ((uint)(3));
			w47.XOptions = ((global::Gtk.AttachOptions)(4));
			w47.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child newUserTable.Gtk.Table+TableChild
			this.pwdLabel = new global::Gtk.Label ();
			this.pwdLabel.Name = "pwdLabel";
			this.pwdLabel.Xalign = 0F;
			this.pwdLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Passwort: ");
			this.newUserTable.Add (this.pwdLabel);
			global::Gtk.Table.TableChild w48 = ((global::Gtk.Table.TableChild)(this.newUserTable [this.pwdLabel]));
			w48.TopAttach = ((uint)(1));
			w48.BottomAttach = ((uint)(2));
			w48.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child newUserTable.Gtk.Table+TableChild
			this.pwPictureBox = new global::Gtk.Image ();
			this.pwPictureBox.Name = "pwPictureBox";
			this.pwPictureBox.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-yes", global::Gtk.IconSize.Menu);
			this.newUserTable.Add (this.pwPictureBox);
			global::Gtk.Table.TableChild w49 = ((global::Gtk.Table.TableChild)(this.newUserTable [this.pwPictureBox]));
			w49.TopAttach = ((uint)(1));
			w49.BottomAttach = ((uint)(2));
			w49.LeftAttach = ((uint)(2));
			w49.RightAttach = ((uint)(3));
			w49.XOptions = ((global::Gtk.AttachOptions)(4));
			w49.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child newUserTable.Gtk.Table+TableChild
			this.pwTextBox = new global::Gtk.Entry ();
			this.pwTextBox.CanFocus = true;
			this.pwTextBox.Name = "pwTextBox";
			this.pwTextBox.IsEditable = true;
			this.pwTextBox.Visibility = false;
			this.pwTextBox.InvisibleChar = '●';
			this.newUserTable.Add (this.pwTextBox);
			global::Gtk.Table.TableChild w50 = ((global::Gtk.Table.TableChild)(this.newUserTable [this.pwTextBox]));
			w50.TopAttach = ((uint)(1));
			w50.BottomAttach = ((uint)(2));
			w50.LeftAttach = ((uint)(1));
			w50.RightAttach = ((uint)(2));
			// Container child newUserTable.Gtk.Table+TableChild
			this.unameLabel = new global::Gtk.Label ();
			this.unameLabel.Name = "unameLabel";
			this.unameLabel.Xalign = 0F;
			this.unameLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Benutzername :");
			this.newUserTable.Add (this.unameLabel);
			global::Gtk.Table.TableChild w51 = ((global::Gtk.Table.TableChild)(this.newUserTable [this.unameLabel]));
			w51.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child newUserTable.Gtk.Table+TableChild
			this.usernameTextBox = new global::Gtk.Entry ();
			this.usernameTextBox.CanFocus = true;
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.IsEditable = true;
			this.usernameTextBox.InvisibleChar = '●';
			this.newUserTable.Add (this.usernameTextBox);
			global::Gtk.Table.TableChild w52 = ((global::Gtk.Table.TableChild)(this.newUserTable [this.usernameTextBox]));
			w52.LeftAttach = ((uint)(1));
			w52.RightAttach = ((uint)(2));
			w52.XOptions = ((global::Gtk.AttachOptions)(4));
			w52.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add (this.newUserTable);
			global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.newUserTable]));
			w53.Position = 7;
			w53.Expand = false;
			w53.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 877;
			this.DefaultHeight = 757;
			this.userdataLabel.Hide ();
			this.hseparator2.Hide ();
			this.pwCTextBox.Hide ();
			this.pwdCLabel.Hide ();
			this.pwdCPictureBox.Hide ();
			this.pwdLabel.Hide ();
			this.pwPictureBox.Hide ();
			this.pwTextBox.Hide ();
			this.unameLabel.Hide ();
			this.Show ();
			this.newCustomer.Activated += new global::System.EventHandler (this.OnApplyAddTBActivated);
			this.closeTB.Activated += new global::System.EventHandler (this.OnCloseTBActivated);
			this.clearTB.Activated += new global::System.EventHandler (this.OnClearTBActivated);
			this.dialogQuestionTB.Activated += new global::System.EventHandler (this.OnDialogQuestionTBActivated);
			this.typCB.Changed += new global::System.EventHandler (this.OnTypCBChanged);
			this.newCompanyButton.Clicked += new global::System.EventHandler (this.OnNewCompanyButtonClicked);
		}
	}
}
