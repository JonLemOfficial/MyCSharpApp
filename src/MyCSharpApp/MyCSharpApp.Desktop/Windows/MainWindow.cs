using System;
using System.Windows.Forms;

using WeifenLuo.WinFormsUI.Docking;

using MyCSharpApp.Desktop.Panels;

namespace MyCSharpApp.Desktop.Windows
{
    public partial class MainWindow : Form {

        // Windows
        private AboutWindow About;

        // Docks
        public SideBarPanel SideBarPanelDock;
        public MainPanel MainPanelDock;

        // Props
        private bool FullScreenMode = false;
        private int InitialWidthSize, InitialHeightSize
            , CurrentWidthSize = 0
            , CurrentHeightSize = 0;

        public MainWindow()
        {
            this.InitializeComponent();

            // Child Windows
            this.About = new AboutWindow();

            // Customizing Docks
            var MainTheme = new VS2015LightTheme();
            this.MainDock.Theme = MainTheme;
            SideBarPanelDock = new SideBarPanel();
            // SideBarDock.MdiParent = Form1.ActiveForm;
            SideBarPanelDock.Show(this.MainDock, DockState.DockLeft);

            MainPanelDock = new MainPanel();
            // MainContentDock.MdiParent = Form1.ActiveForm;
            MainPanelDock.Show(this.MainDock, DockState.Document);
        }

        #region Methods and functions associated to window events and others

        private void HandleMainWindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey && e.KeyCode == Keys.Q)
            {
                DialogResult opt = MessageBox.Show(
                    "¿Are you sure yo want to close this Window?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (opt == DialogResult.Yes)
                {
                    this.Dispose();
                    this.Close();
                }
                return;
            }

            // Hide/Show Menu Bar
            if (e.Control && e.Shift && e.KeyCode == Keys.B)
            {
                if (this.MenuBar.Visible == false)
                {
                    this.MenuBar.Visible = true;
                    this.barraDeMenusToolStripMenuItem.Checked = true;
                }
                else
                {
                    this.MenuBar.Visible = false;
                    this.barraDeMenusToolStripMenuItem.Checked = false;
                }
                return;
            }

            // Hide/Show Tool Bar
            if (e.Control && e.Shift && e.KeyCode == Keys.T && !e.Alt)
            {
                this.ToggleToolBarContainerVisible();
                return;
            }

            // Hide/Show Side Bar
            if (e.Control && e.KeyCode == Keys.B && !e.Shift && !e.Alt)
            {
                this.ToggleSideBar();
                return;
            }

            if (e.KeyCode == Keys.F11)
            {
                this.ToggleFullScreenMode();
                return;
            }
        }

        private void ToggleFullScreenMode()
        {
            this.FullScreenMode = !this.FullScreenMode;

            if (this.FullScreenMode)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                // this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.SetClientSizeCore(this.CurrentWidthSize, this.CurrentHeightSize);
            }
        }

        public void ToggleSideBarPanelCheckState(string Option)
        {
            switch (Option)
            {
                case "SIDEBAR":
                    this.mostrarBarraLateralToolStripMenuItem.Checked = false;
                    break;
                case "MAIN_PANEL":
                    this.MainPaneToolStripMenuItem.Checked = false;
                    break;
                default:
                    return;
            }
        }

        private void CloseMainWindow()
        {
            this.Dispose();
            this.Close();
        }

        private void OpenAboutWindow()
        {
            if ( this.About.IsDisposed )
            {
                this.About = new AboutWindow();
            }

            if ( this.About.Created )
            {
                this.About.BringToFront();
            }
            else
            {
                this.About.StartPosition = FormStartPosition.CenterScreen;
                this.About.Show();
            }
        }

        private void ToggleToolBarContainerVisible()
        {
            
            if (this.ToolBarContainer.TopToolStripPanel.Visible == false)
            {
                this.ToolBarContainer.TopToolStripPanel.Visible = true;
            }
            else
            {
                this.ToolBarContainer.TopToolStripPanel.Visible = false;
            }
        }

        public void ToggleSideBar()
        {
            if (this.SideBarPanelDock.IsDisposed)
            {
                this.SideBarPanelDock = new SideBarPanel();
                this.SideBarPanelDock.Show(this.MainDock, DockState.DockLeft);
                this.mostrarBarraLateralToolStripMenuItem.Checked = true;
            }
            else
            {
                this.SideBarPanelDock.Close();
                this.SideBarPanelDock.Dispose();
                this.mostrarBarraLateralToolStripMenuItem.Checked = false;
            }
        }

        public void ToggleMainPanel()
        {
            if (this.MainPanelDock.IsDisposed)
            {
                this.MainPanelDock = new MainPanel();
                this.MainPanelDock.Show(this.MainDock, DockState.Document);
                this.MainPaneToolStripMenuItem.Checked = true;
            }
            else
            {
                this.MainPanelDock.Close();
                this.MainPanelDock.Dispose();
                this.MainPaneToolStripMenuItem.Checked = false;
            }
        }

        #endregion

        #region Events

        private void MyForm_Load(object sender, EventArgs e)
        {
            this.InitialWidthSize = this.Size.Width;
            this.InitialHeightSize = this.Size.Height;
        }

        private void MyForm_KeyDown(object sender, KeyEventArgs e)
        {
            this.HandleMainWindowKeyDown(sender, e);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenAboutWindow();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseMainWindow();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveFileDialog.ShowDialog();
        }

        private void pantallaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ToggleFullScreenMode();
        }

        private void mostrarBarraDeHerramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ToggleToolBarContainerVisible();
        }

        private void mostrarBarraLateralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ToggleSideBar();
        }

        private void MainPaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ToggleMainPanel();
        }

        private void MainDock_ActiveContentChanged(object sender, EventArgs e)
        {

        }

        private void barraDeMenusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MenuBar.Visible = false;
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.CurrentWidthSize = this.Size.Width;
                this.CurrentHeightSize = this.Size.Height;
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenFileDialog.ShowDialog();
        }

        #endregion
    }
}