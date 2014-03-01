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
		public SpecificWindow (/*int id, int name*/) : //Parameter werden für die Projektdetail - Auslesung benötigt
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();

			#region Labelstyle
			projectTitelLabel.Pattern = "______________________________";
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
			List<String> projDetail = MainClass.connection.readProjectDetails (1, "TESTProjekt");

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
		}
	}
}

