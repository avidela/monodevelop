// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Database.Components {
    
    
    public partial class SqlEditorWidget {
        
        private Gtk.ScrolledWindow scrolledwindow;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Database.Components.SqlEditorWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.Database.Components.SqlEditorWidget";
            // Container child MonoDevelop.Database.Components.SqlEditorWidget.Gtk.Container+ContainerChild
            this.scrolledwindow = new Gtk.ScrolledWindow();
            this.scrolledwindow.CanFocus = true;
            this.scrolledwindow.Name = "scrolledwindow";
            this.scrolledwindow.ShadowType = ((Gtk.ShadowType)(1));
            this.Add(this.scrolledwindow);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
        }
    }
}
