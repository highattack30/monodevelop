
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.AddinAuthoring
{
	public partial class SelectNodeSetDialog
	{
		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label label1;

		private global::Gtk.ComboBoxEntry combo;

		private global::MonoDevelop.AddinAuthoring.NodeSetEditorWidget nodeseteditor;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.AddinAuthoring.SelectNodeSetDialog
			this.Name = "MonoDevelop.AddinAuthoring.SelectNodeSetDialog";
			this.Title = global::Mono.Addins.AddinManager.CurrentLocalizer.GetString ("Select Node Set");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			// Internal child MonoDevelop.AddinAuthoring.SelectNodeSetDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 12;
			this.vbox3.BorderWidth = ((uint)(9));
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0f;
			this.label1.LabelProp = global::Mono.Addins.AddinManager.CurrentLocalizer.GetString ("Node Set:");
			this.hbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.combo = global::Gtk.ComboBoxEntry.NewText ();
			this.combo.Name = "combo";
			this.hbox1.Add (this.combo);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.combo]));
			w3.Position = 1;
			this.vbox3.Add (this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.nodeseteditor = new global::MonoDevelop.AddinAuthoring.NodeSetEditorWidget ();
			this.nodeseteditor.Events = ((global::Gdk.EventMask)(256));
			this.nodeseteditor.Name = "nodeseteditor";
			this.nodeseteditor.AllowEditing = false;
			this.vbox3.Add (this.nodeseteditor);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.nodeseteditor]));
			w5.Position = 1;
			w1.Add (this.vbox3);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(w1[this.vbox3]));
			w6.Position = 0;
			// Internal child MonoDevelop.AddinAuthoring.SelectNodeSetDialog.ActionArea
			global::Gtk.HButtonBox w7 = this.ActionArea;
			w7.Name = "dialog1_ActionArea";
			w7.Spacing = 6;
			w7.BorderWidth = ((uint)(5));
			w7.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w8 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w7[this.buttonCancel]));
			w8.Expand = false;
			w8.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w9 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w7[this.buttonOk]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 498;
			this.DefaultHeight = 346;
			this.Show ();
			this.combo.Changed += new global::System.EventHandler (this.OnComboChanged);
		}
	}
}
