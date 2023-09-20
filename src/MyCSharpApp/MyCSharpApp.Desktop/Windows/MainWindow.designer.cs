using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace MyCSharpApp.Desktop.Windows
{
    
    partial class MainWindow {
    
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ToolBarContainer = new System.Windows.Forms.ToolStripContainer();
            this.MainDock = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.ToolBarMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.MenuBarItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImprimirStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rehacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDeMenusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarBarraDeHerramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarBarraLateralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.pantallaCompletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consolaDeDepuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportarUnProblemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusBarInfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ToolBarContainer.ContentPanel.SuspendLayout();
            this.ToolBarContainer.TopToolStripPanel.SuspendLayout();
            this.ToolBarContainer.SuspendLayout();
            this.ToolBarMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBarContainer
            // 
            this.ToolBarContainer.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            // 
            // ToolBarContainer.BottomToolStripPanel
            // 
            this.ToolBarContainer.BottomToolStripPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            // 
            // ToolBarContainer.ContentPanel
            // 
            this.ToolBarContainer.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToolBarContainer.ContentPanel.Controls.Add(this.MainDock);
            resources.ApplyResources(this.ToolBarContainer.ContentPanel, "ToolBarContainer.ContentPanel");
            resources.ApplyResources(this.ToolBarContainer, "ToolBarContainer");
            // 
            // ToolBarContainer.LeftToolStripPanel
            // 
            this.ToolBarContainer.LeftToolStripPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ToolBarContainer.Name = "ToolBarContainer";
            // 
            // ToolBarContainer.RightToolStripPanel
            // 
            this.ToolBarContainer.RightToolStripPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            // 
            // ToolBarContainer.TopToolStripPanel
            // 
            this.ToolBarContainer.TopToolStripPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ToolBarContainer.TopToolStripPanel.Controls.Add(this.ToolBarMain);
            this.ToolBarContainer.TopToolStripPanel.Controls.Add(this.toolStrip1);
            resources.ApplyResources(this.ToolBarContainer.TopToolStripPanel, "ToolBarContainer.TopToolStripPanel");
            // 
            // MainDock
            // 
            resources.ApplyResources(this.MainDock, "MainDock");
            this.MainDock.DockBackColor = System.Drawing.SystemColors.ControlDark;
            this.MainDock.Name = "MainDock";
            this.MainDock.ActiveContentChanged += new System.EventHandler(this.MainDock_ActiveContentChanged);
            // 
            // ToolBarMain
            // 
            this.ToolBarMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            resources.ApplyResources(this.ToolBarMain, "ToolBarMain");
            this.ToolBarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton4});
            this.ToolBarMain.Name = "ToolBarMain";
            this.ToolBarMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButton4, "toolStripButton4");
            this.toolStripButton4.Name = "toolStripButton4";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton5});
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.Name = "toolStripButton2";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButton3, "toolStripButton3");
            this.toolStripButton3.Name = "toolStripButton3";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.ForeColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.toolStripButton5, "toolStripButton5");
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Tag = "Este es un tag";
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBarItem_File,
            this.editarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.ayudaToolStripMenuItem1});
            resources.ApplyResources(this.MenuBar, "MenuBar");
            this.MenuBar.Name = "MenuBar";
            // 
            // MenuBarItem_File
            // 
            this.MenuBarItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.toolStripSeparator5,
            this.importarToolStripMenuItem,
            this.exportarToolStripMenuItem,
            this.ImprimirStripMenuItem,
            this.preferenciasToolStripMenuItem,
            this.ajustesToolStripMenuItem,
            this.toolStripSeparator4,
            this.salirToolStripMenuItem});
            this.MenuBarItem_File.Name = "MenuBarItem_File";
            resources.ApplyResources(this.MenuBarItem_File, "MenuBarItem_File");
            // 
            // abrirToolStripMenuItem
            // 
            resources.ApplyResources(this.abrirToolStripMenuItem, "abrirToolStripMenuItem");
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            resources.ApplyResources(this.nuevoToolStripMenuItem, "nuevoToolStripMenuItem");
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            // 
            // guardarToolStripMenuItem
            // 
            resources.ApplyResources(this.guardarToolStripMenuItem, "guardarToolStripMenuItem");
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Image = global::MyCSharpApp.Desktop.Properties.Resources.SaveAllHS;
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            resources.ApplyResources(this.guardarComoToolStripMenuItem, "guardarComoToolStripMenuItem");
            this.guardarComoToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            resources.ApplyResources(this.importarToolStripMenuItem, "importarToolStripMenuItem");
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            resources.ApplyResources(this.exportarToolStripMenuItem, "exportarToolStripMenuItem");
            // 
            // ImprimirStripMenuItem
            // 
            resources.ApplyResources(this.ImprimirStripMenuItem, "ImprimirStripMenuItem");
            this.ImprimirStripMenuItem.Name = "ImprimirStripMenuItem";
            // 
            // preferenciasToolStripMenuItem
            // 
            this.preferenciasToolStripMenuItem.Name = "preferenciasToolStripMenuItem";
            resources.ApplyResources(this.preferenciasToolStripMenuItem, "preferenciasToolStripMenuItem");
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem});
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            resources.ApplyResources(this.ajustesToolStripMenuItem, "ajustesToolStripMenuItem");
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            resources.ApplyResources(this.generalToolStripMenuItem, "generalToolStripMenuItem");
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            resources.ApplyResources(this.salirToolStripMenuItem, "salirToolStripMenuItem");
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rehacerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripSeparator3,
            this.cortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            resources.ApplyResources(this.editarToolStripMenuItem, "editarToolStripMenuItem");
            // 
            // rehacerToolStripMenuItem
            // 
            this.rehacerToolStripMenuItem.Image = global::MyCSharpApp.Desktop.Properties.Resources.Edit_RedoHS;
            this.rehacerToolStripMenuItem.Name = "rehacerToolStripMenuItem";
            resources.ApplyResources(this.rehacerToolStripMenuItem, "rehacerToolStripMenuItem");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::MyCSharpApp.Desktop.Properties.Resources.Edit_UndoHS;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // cortarToolStripMenuItem
            // 
            resources.ApplyResources(this.cortarToolStripMenuItem, "cortarToolStripMenuItem");
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            // 
            // copiarToolStripMenuItem
            // 
            resources.ApplyResources(this.copiarToolStripMenuItem, "copiarToolStripMenuItem");
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            // 
            // pegarToolStripMenuItem
            // 
            resources.ApplyResources(this.pegarToolStripMenuItem, "pegarToolStripMenuItem");
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraDeMenusToolStripMenuItem,
            this.mostrarBarraDeHerramientasToolStripMenuItem,
            this.mostrarBarraLateralToolStripMenuItem,
            this.toolStripSeparator9,
            this.pantallaCompletaToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            resources.ApplyResources(this.verToolStripMenuItem, "verToolStripMenuItem");
            // 
            // barraDeMenusToolStripMenuItem
            // 
            this.barraDeMenusToolStripMenuItem.Checked = true;
            this.barraDeMenusToolStripMenuItem.CheckOnClick = true;
            this.barraDeMenusToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.barraDeMenusToolStripMenuItem.Name = "barraDeMenusToolStripMenuItem";
            resources.ApplyResources(this.barraDeMenusToolStripMenuItem, "barraDeMenusToolStripMenuItem");
            this.barraDeMenusToolStripMenuItem.Click += new System.EventHandler(this.barraDeMenusToolStripMenuItem_Click);
            // 
            // mostrarBarraDeHerramientasToolStripMenuItem
            // 
            this.mostrarBarraDeHerramientasToolStripMenuItem.Checked = true;
            this.mostrarBarraDeHerramientasToolStripMenuItem.CheckOnClick = true;
            this.mostrarBarraDeHerramientasToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mostrarBarraDeHerramientasToolStripMenuItem.Name = "mostrarBarraDeHerramientasToolStripMenuItem";
            resources.ApplyResources(this.mostrarBarraDeHerramientasToolStripMenuItem, "mostrarBarraDeHerramientasToolStripMenuItem");
            this.mostrarBarraDeHerramientasToolStripMenuItem.Click += new System.EventHandler(this.mostrarBarraDeHerramientasToolStripMenuItem_Click);
            // 
            // mostrarBarraLateralToolStripMenuItem
            // 
            this.mostrarBarraLateralToolStripMenuItem.Checked = true;
            this.mostrarBarraLateralToolStripMenuItem.CheckOnClick = true;
            this.mostrarBarraLateralToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mostrarBarraLateralToolStripMenuItem.Name = "mostrarBarraLateralToolStripMenuItem";
            resources.ApplyResources(this.mostrarBarraLateralToolStripMenuItem, "mostrarBarraLateralToolStripMenuItem");
            this.mostrarBarraLateralToolStripMenuItem.Click += new System.EventHandler(this.mostrarBarraLateralToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            // 
            // pantallaCompletaToolStripMenuItem
            // 
            this.pantallaCompletaToolStripMenuItem.CheckOnClick = true;
            this.pantallaCompletaToolStripMenuItem.Name = "pantallaCompletaToolStripMenuItem";
            resources.ApplyResources(this.pantallaCompletaToolStripMenuItem, "pantallaCompletaToolStripMenuItem");
            this.pantallaCompletaToolStripMenuItem.Click += new System.EventHandler(this.pantallaCompletaToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainPaneToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            resources.ApplyResources(this.herramientasToolStripMenuItem, "herramientasToolStripMenuItem");
            // 
            // MainPaneToolStripMenuItem
            // 
            this.MainPaneToolStripMenuItem.Checked = true;
            this.MainPaneToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MainPaneToolStripMenuItem.Name = "MainPaneToolStripMenuItem";
            resources.ApplyResources(this.MainPaneToolStripMenuItem, "MainPaneToolStripMenuItem");
            this.MainPaneToolStripMenuItem.Click += new System.EventHandler(this.MainPaneToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avanzadoToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            resources.ApplyResources(this.ayudaToolStripMenuItem, "ayudaToolStripMenuItem");
            // 
            // avanzadoToolStripMenuItem
            // 
            this.avanzadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consolaDeDepuraciónToolStripMenuItem});
            this.avanzadoToolStripMenuItem.Name = "avanzadoToolStripMenuItem";
            resources.ApplyResources(this.avanzadoToolStripMenuItem, "avanzadoToolStripMenuItem");
            // 
            // consolaDeDepuraciónToolStripMenuItem
            // 
            this.consolaDeDepuraciónToolStripMenuItem.Name = "consolaDeDepuraciónToolStripMenuItem";
            resources.ApplyResources(this.consolaDeDepuraciónToolStripMenuItem, "consolaDeDepuraciónToolStripMenuItem");
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportarUnProblemaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            resources.ApplyResources(this.ayudaToolStripMenuItem1, "ayudaToolStripMenuItem1");
            // 
            // reportarUnProblemaToolStripMenuItem
            // 
            this.reportarUnProblemaToolStripMenuItem.Name = "reportarUnProblemaToolStripMenuItem";
            resources.ApplyResources(this.reportarUnProblemaToolStripMenuItem, "reportarUnProblemaToolStripMenuItem");
            // 
            // acercaDeToolStripMenuItem
            // 
            resources.ApplyResources(this.acercaDeToolStripMenuItem, "acercaDeToolStripMenuItem");
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarInfoLabel});
            this.StatusBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            resources.ApplyResources(this.StatusBar, "StatusBar");
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.SizingGrip = false;
            // 
            // StatusBarInfoLabel
            // 
            this.StatusBarInfoLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StatusBarInfoLabel.Name = "StatusBarInfoLabel";
            resources.ApplyResources(this.StatusBarInfoLabel, "StatusBarInfoLabel");
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ToolBarContainer);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MenuBar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuBar;
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyDown);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.ToolBarContainer.ContentPanel.ResumeLayout(false);
            this.ToolBarContainer.TopToolStripPanel.ResumeLayout(false);
            this.ToolBarContainer.TopToolStripPanel.PerformLayout();
            this.ToolBarContainer.ResumeLayout(false);
            this.ToolBarContainer.PerformLayout();
            this.ToolBarMain.ResumeLayout(false);
            this.ToolBarMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip MenuBar;
        private ToolStripMenuItem MenuBarItem_File;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem1;
        private StatusStrip StatusBar;
        private ToolStrip ToolBarMain;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton4;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem importarToolStripMenuItem;
        private ToolStripMenuItem exportarToolStripMenuItem;
        private ToolStripMenuItem preferenciasToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem cortarToolStripMenuItem;
        private ToolStripMenuItem pegarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem rehacerToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private SaveFileDialog SaveFileDialog;
        private OpenFileDialog OpenFileDialog;
        private ToolStripMenuItem ajustesToolStripMenuItem;
        private ToolStripMenuItem barraDeMenusToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem pantallaCompletaToolStripMenuItem;
        private ToolStripMenuItem herramientasToolStripMenuItem;
        private ToolStripMenuItem mostrarBarraDeHerramientasToolStripMenuItem;
        private ToolStripMenuItem ImprimirStripMenuItem;
        private ToolStripContainer ToolBarContainer;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton5;
        private WeifenLuo.WinFormsUI.Docking.DockPanel MainDock;
        private ToolStripMenuItem mostrarBarraLateralToolStripMenuItem;
        private ToolStripMenuItem MainPaneToolStripMenuItem;
        public ToolStripStatusLabel StatusBarInfoLabel;
        private ToolStripMenuItem avanzadoToolStripMenuItem;
        private ToolStripMenuItem consolaDeDepuraciónToolStripMenuItem;
        private ToolStripMenuItem reportarUnProblemaToolStripMenuItem;
        private ToolStripMenuItem generalToolStripMenuItem;
    }
}

