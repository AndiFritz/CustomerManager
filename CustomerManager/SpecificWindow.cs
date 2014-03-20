using System;
using Gtk;
using System.Drawing;
using System.Drawing.Design;
using Gdk;
using System.Collections.Generic;


namespace CustomerManager
{
	public partial class SpecificWindow : Gtk.Window
	{

		string startTime = ""; // für die Identifizierung, bei welchem Datensatz die Endzeit eingetragen werden soll




		public SpecificWindow (/*int id, int name, int UserID */) : //Parameter werden für die Projektdetail - Auslesung benötigt
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();

//			projectTitelLabel.Text = name; --> Projekttitel ändern


			#region Labelstyle
			projectTitelLabel.Pattern = "________________________________________________________________________________"; //Unterstreichung - Projekttitel
			Gdk.Color bluecolor = new Gdk.Color (255, 100, 50);
			projectTitelLabel.ModifyFg (Gtk.StateType.Normal, bluecolor);
			projectTitelLabel.ModifyFont (Pango.FontDescription.FromString ("Calibri 20"));
			timeLabel.ModifyFont (Pango.FontDescription.FromString ("Calibri, Bold 15"));
			terminLabel.ModifyFont (Pango.FontDescription.FromString ("Calibri, Bold 15"));
			TimesLabel.ModifyFont (Pango.FontDescription.FromString ("Calibri, Bold 15"));
			projectdescriptionLabel.ModifyFont (Pango.FontDescription.FromString ("Calibri, Bold 15"));
			startdateBarLabel.ModifyFont (Pango.FontDescription.FromString ("Calibri, Bold 12"));
			enddateBarLabel.ModifyFont (Pango.FontDescription.FromString ("Calibri, Bold 12"));
			label17.ModifyFont (Pango.FontDescription.FromString ("Calibri, Bold 12"));
			gesPriceLabel.ModifyFont (Pango.FontDescription.FromString ("Calibri, Bold 12"));
			label21.ModifyFont (Pango.FontDescription.FromString ("Calibri, Bold 12"));

			table5.ModifyFg (Gtk.StateType.Normal, bluecolor);
			table5.ModifyBg (Gtk.StateType.Normal, bluecolor);
			vbox12.ModifyFg (Gtk.StateType.Normal, bluecolor);
			#endregion

			#region Projektdetails - Auslesung
			List<String> projDetail = MainClass.connection.readProjectDetails (1, "TESTProjekt"); // PARAMETER neu einfügen!

			int i= 1; 

			foreach (string s in projDetail) {
				if(i == 1)
				{
					startdateBarLabel.Text = s;
					startdateLabel.Text = s;
				}
				if(i == 2)
				{
					enddateBarLabel.Text = s; 
					enddateLabel.Text = s; 
				}
				if (i == 3) {
					TextBuffer buffer = ProjectDescriptionTextView.Buffer;
					buffer.Text = s;
				}
				if(i == 4)
				{
					hourPriceLabel.Text = s;
					break;
				}
				i++;
			}
			#endregion

			#region Bar - Schieber

			Int64 timeNow = Convert.ToInt64(DateTime.Now.Ticks); //aktuelle Zeit in eine Zahl konvertieren

			DateTime starttime = Convert.ToDateTime(startdateBarLabel.Text); // Datum von Label in DateTime konvertieren
			Int64 timeStart = Convert.ToInt64 (starttime.Ticks); // startzeit in eine Zahl konvertieren

			DateTime endtime = Convert.ToDateTime(enddateBarLabel.Text); // Datum von Endlabel in DateTime konvertieren
			Int64 timeEnd = Convert.ToInt64(endtime.Ticks); // eindzeit in eine Zahl konvertieren

			TimeHscale.Sensitive = false; // Keine Verschiebung möglich
			TimeHscale.Adjustment.Lower = timeStart; // Startwert
			TimeHscale.Adjustment.Upper = timeEnd; // Endwert
			TimeHscale.Value = timeNow; // akutelle Zeit zuweisen

			#endregion
		
		
			#region Berechnung der Geldbeträge - Stundenbeträge

			Int64 gesDurationMin = MainClass.connection.readSumHours(1); // ProjektID übergeben statt 1 !!!!!!!!!!!

			Single Min = Convert.ToSingle(gesDurationMin);

			decimal gesDurationHour = Convert.ToDecimal (Min / 60);



			#endregion
		

			#region TreeView füllen
			// Create a column for the date name
			Gtk.TreeViewColumn dateColumn = new Gtk.TreeViewColumn ();
			dateColumn.Title = "Datum";
			
			// Create the text cell that will display the date
			Gtk.CellRendererText dateNameCell = new Gtk.CellRendererText ();
			dateColumn.PackStart (dateNameCell, true); // Add the cell to the column
			
			// Create a column for the description 
			Gtk.TreeViewColumn descriptColumn = new Gtk.TreeViewColumn ();
			descriptColumn.Title = "Beschreibung";
			
			// Do the same for the descript column
			Gtk.CellRendererText descriptTitleCell = new Gtk.CellRendererText ();
			descriptColumn.PackStart (descriptTitleCell, true);

			// Create a column for the description 
			Gtk.TreeViewColumn durationColumn = new Gtk.TreeViewColumn ();
			durationColumn.Title = "Dauer";
			Gtk.CellRendererText durationTitleCell = new Gtk.CellRendererText ();
			durationColumn.PackStart (durationTitleCell, true); 

			Gtk.TreeViewColumn priceColumn = new Gtk.TreeViewColumn ();
			priceColumn.Title = "Preis";
			Gtk.CellRendererText priceTitleCell = new Gtk.CellRendererText ();
			priceColumn.PackStart (priceTitleCell, true);

			Gtk.TreeViewColumn userColumn = new Gtk.TreeViewColumn ();
			userColumn.Title = "Bearbeiter";
			Gtk.CellRendererText userTitleCell = new Gtk.CellRendererText ();
			userColumn.PackStart (userTitleCell, true);

			
			// Add the columns to the TreeView
			StempsTreeview.AppendColumn (dateColumn);
			StempsTreeview.AppendColumn (descriptColumn);
			StempsTreeview.AppendColumn (durationColumn);
			StempsTreeview.AppendColumn (priceColumn);
			StempsTreeview.AppendColumn (userColumn);
			
			// Tell the Cell Renderers which items in the model to display
			dateColumn.AddAttribute (dateNameCell, "text", 0);
			descriptColumn.AddAttribute (descriptTitleCell, "text", 1);
			durationColumn.AddAttribute(durationTitleCell, "text", 2);
			priceColumn.AddAttribute(priceTitleCell, "text", 3);
			userColumn.AddAttribute(userTitleCell, "text", 4);



			//Test
//			// Create a model that will hold two strings - Artist Name and Song Title
//			Gtk.ListStore stempsListStore = new Gtk.ListStore (typeof (string), typeof (string), typeof (string), typeof (string), typeof (string));
//			
//			// Add some data to the store
//			stempsListStore.AppendValues ("Datum", "Beschreibung", "Dauer", "Preis", "Bearbeiter");
//
//
//			List<String> stempsDetail = MainClass.connection.readStemps (1); // PARAMETER neu einfügen!
//			
//			foreach (string s in stempsDetail) {
//				stempsListStore.AppendValues (s, s, s, s);
//
//			}


			
			// Assign the model to the TreeView
//			StempsTreeview.Model = stempsListStore;
		

			#endregion
		}

		protected void OnStartButtonClicked (object sender, EventArgs e) // Start - Button gedrückt
		{
			if (starttimeLabel.Text != "") {
				MessageDialog md = new MessageDialog (this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Bitte beenden Sie zuerst Ihr aktuelle Arbeit!");
				md.Run ();
				md.Destroy ();
				return;
			}

			DateTime now = DateTime.Now; 
			string currentDate = now.ToShortDateString ();
			string currentTime = now.ToShortTimeString ();
			string description = Convert.ToString (workDescriptTextBox.Text);

			bool addStartTime = MainClass.connection.addStartTime (1, currentDate, currentTime, description, 1);

			if (addStartTime = true) {
				startTime = currentTime;
				starttimeLabel.Text = currentTime;
			}
		}


		protected void OnEndButtonClicked (object sender, EventArgs e)
		{
			DateTime now = DateTime.Now; 
			string currentDate = now.ToShortDateString ();
			string currentTime = now.ToShortTimeString ();

			string workdescription = Convert.ToString (workDescriptTextBox.Text); 

			DateTime startTimeBE = Convert.ToDateTime (startTime);

			TimeSpan workDuration = now - startTimeBE; 

			int duration = workDuration.Minutes; // Differenz in Stunden 

			Int64 hourprice = Convert.ToInt64 (hourPriceLabel.Text);
			Int64 minprice = hourprice / 60; 

			Int32 price = Convert.ToInt32 (minprice * duration);

		

			if (workdescription == "") {
				MessageDialog md = new MessageDialog (this, DialogFlags.Modal, MessageType.Warning, ButtonsType.OkCancel, "Es wurde keine Beschreibung für die Arbeit eingetragen! Bitte tragen Sie etwas ein, wenn es auf der Rechnung aufgelistet sein sollte! Wenn Sie EINE BESCHREIBUNG eintragen wollen, drücken Sie Cancel.");
				ResponseType response = (ResponseType)md.Run ();


				if (response == ResponseType.Cancel) {
					md.Destroy ();
					return; 
				}

				if (response == ResponseType.Ok) {
					md.Destroy ();

					bool addEndTime = MainClass.connection.addEndTime (1, currentDate, startTime, currentTime, duration, workdescription, 1, price);

					if (addEndTime == true) {
						endtimeLabel.Text = currentTime;
						MessageDialog wd = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Arbeit beendet! Viel Spaß beim Entspannen!");
						wd.Run ();
						wd.Destroy ();

						starttimeLabel.Text = "";  // Startzeit in Startzeitlabel entfernen
						endtimeLabel.Text = "";  // Endzeit in Endzeitlabel entfernen
						workDescriptTextBox.Text = "";  // Tätigkeits-beschreibung entfernen
					}
				}
			} else {
				bool addEndTime = MainClass.connection.addEndTime (1, currentDate, startTime, currentTime, duration, workdescription, 1, price);
				
				if (addEndTime == true) {
					endtimeLabel.Text = currentTime;
					MessageDialog wd = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Arbeit beendet! Viel Spaß beim Entspannen!");
					wd.Run ();
					wd.Destroy ();
					
					starttimeLabel.Text = "";  // Startzeit in Startzeitlabel entfernen
					endtimeLabel.Text = "";  // Endzeit in Endzeitlabel entfernen
					workDescriptTextBox.Text = "";  // Tätigkeits-beschreibung entfernen
				}
			}
		}
	}
}

