
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vBoxmain;
	
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.Button buttonAdelante;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vBoxmain = new global::Gtk.VBox ();
		this.vBoxmain.Name = "vBoxmain";
		this.vBoxmain.Spacing = 6;
		// Container child vBoxmain.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.buttonAdelante = new global::Gtk.Button ();
		this.buttonAdelante.CanFocus = true;
		this.buttonAdelante.Name = "buttonAdelante";
		this.buttonAdelante.UseUnderline = true;
		this.buttonAdelante.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
		this.hbox1.Add (this.buttonAdelante);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonAdelante]));
		w1.Position = 2;
		w1.Expand = false;
		w1.Fill = false;
		this.vBoxmain.Add (this.hbox1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vBoxmain [this.hbox1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		this.Add (this.vBoxmain);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
