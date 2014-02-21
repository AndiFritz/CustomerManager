using System;
using Gtk;
using System.Drawing;
using System.Drawing.Design;
using Gdk;


namespace CustomerManager
{
	public partial class SpecificWindow : Gtk.Window
	{
		public SpecificWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();

			#region Labelstyle
			projectTitelLabel.Pattern = "______________________________";
			Gdk.Color color = new Gdk.Color();
			Gdk.Color bluecolor = new Gdk.Color(255,100,50);
			projectTitelLabel.ModifyFg(Gtk.StateType.Normal, bluecolor);
			projectTitelLabel.ModifyFont(Pango.FontDescription.FromString ("Calibri 20"));
			timeLabel.ModifyFont (Pango.FontDescription.FromString("Calibri, Bold 15"));
			terminLabel.ModifyFont(Pango.FontDescription.FromString("Calibri, Bold 15"));
			TimesLabel.ModifyFont(Pango.FontDescription.FromString("Calibri, Bold 15"));
			projectdescriptionLabel.ModifyFont(Pango.FontDescription.FromString("Calibri, Bold 15"));
			startdateBarLabel.ModifyFont(Pango.FontDescription.FromString("Calibri, Bold 12"));
			enddateBarLabel.ModifyFont(Pango.FontDescription.FromString("Calibri, Bold 12"));
			label17.ModifyFont(Pango.FontDescription.FromString("Calibri, Bold 12"));
			gesPriceLabel.ModifyFont(Pango.FontDescription.FromString("Calibri, Bold 12"));
			label21.ModifyFont(Pango.FontDescription.FromString("Calibri, Bold 12"));
			#endregion


			table5.ModifyFg(Gtk.StateType.Normal, bluecolor);
			table5.ModifyBg(Gtk.StateType.Normal, bluecolor);
		}
	}
}

