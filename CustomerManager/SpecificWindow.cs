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

//			Int64 gesDuration = MainClass.connection.readSumHours(1); // ProjektID übergeben statt 1 !!!!!!!!!!!





			#endregion
		
		}

		protected void OnStartButtonClicked (object sender, EventArgs e) // Start - Button gedrückt
		{
			DateTime now = DateTime.Now; 
			string currentDate = now.ToShortDateString ();
			string currentTime = now.ToShortTimeString ();
			string description = Convert.ToString (workDescriptTextBox.Text);

			bool addStartTime = MainClass.connection.addStartTime (1, currentDate, currentTime, description, 1);

			if (addStartTime = true) {
				starttimeLabel.Text = currentTime;
			}

		}


		protected void OnEndButtonClicked (object sender, EventArgs e)
		{
			DateTime now = DateTime.Now; 
			string currentTime = now.ToShortTimeString ();

			string workdescription = Convert.ToString (workDescriptTextBox.Text); 

			if (workdescription == "") {
				MessageDialog md = new MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.OkCancel, "Es wurde keine Beschreibung für die Arbeit eingetragen! Bitte tragen Sie etwas ein, wenn es auf der Rechnung aufgelistet sein sollte!                        Wenn Sie KEINE BESCHREIBUNG eintragen wollen, drücken SIE Cancel");
				md.Run();
				md.Destroy();

			}


			bool addEndTime; 
		}
	}
}

