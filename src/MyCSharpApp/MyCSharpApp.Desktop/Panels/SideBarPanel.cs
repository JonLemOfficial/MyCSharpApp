using System;
using System.Windows.Forms;

using WeifenLuo.WinFormsUI.Docking;

using MyCSharpApp.Desktop.Windows;

namespace MyCSharpApp.Desktop.Panels
{
    public partial class SideBarPanel : DockContent
    {
        public SideBarPanel()
        {
            InitializeComponent();
        }

        private void SideBarPanel_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            MainWindow frm = (MainWindow) Application.OpenForms["MainWindow"];
            frm.ToggleSideBarPanelCheckState("SIDEBAR");
        }
    }
}
