namespace MyCSharpApp.Desktop.Panels
{
    partial class MainPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.Tabs = new System.Windows.Forms.TabControl();
            this.UsersTab = new System.Windows.Forms.TabPage();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.UsersTabSearchLbl = new System.Windows.Forms.ToolStripLabel();
            this.UsersTabSearchTxt = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ImportDataBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.cSVFilecsvToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLDocumentxmlToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportAsBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.pDFReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelDocumentxlsxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVFilecsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLDocumentxmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLDocumenthtmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLDatasqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONDataFilejsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textDocumenttxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ClearEntriesBtn = new System.Windows.Forms.ToolStripButton();
            this.EditUserBtn = new System.Windows.Forms.ToolStripButton();
            this.RemoveUserBtn = new System.Windows.Forms.ToolStripButton();
            this.ViewPDFBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.NumRowsCb = new System.Windows.Forms.ToolStripComboBox();
            this.GetUsersBtn = new System.Windows.Forms.ToolStripButton();
            this.UsersDataGrid = new System.Windows.Forms.DataGridView();
            this.ProductsTab = new System.Windows.Forms.TabPage();
            this.GetProductsBtn = new System.Windows.Forms.Button();
            this.ProductsDataGrid = new System.Windows.Forms.DataGridView();
            this.CreateUserGB = new System.Windows.Forms.GroupBox();
            this.VerifiedChk = new System.Windows.Forms.CheckBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.BirthDateTxt = new System.Windows.Forms.DateTimePicker();
            this.BirthDateLbl = new System.Windows.Forms.Label();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AgeTxt = new System.Windows.Forms.NumericUpDown();
            this.AgeLbl = new System.Windows.Forms.Label();
            this.UserGenreGB = new System.Windows.Forms.GroupBox();
            this.FemaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.MaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.LastnameTxt = new System.Windows.Forms.TextBox();
            this.LastnameLbl = new System.Windows.Forms.Label();
            this.FirstnameTxt = new System.Windows.Forms.TextBox();
            this.FirstnameLbl = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.DllMessageBtn = new System.Windows.Forms.Button();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanelStatusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Tabs.SuspendLayout();
            this.UsersTab.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).BeginInit();
            this.ProductsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).BeginInit();
            this.CreateUserGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeTxt)).BeginInit();
            this.UserGenreGB.SuspendLayout();
            this.MainPanelStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Controls.Add(this.UsersTab);
            this.Tabs.Controls.Add(this.ProductsTab);
            this.Tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Tabs.ItemSize = new System.Drawing.Size(30, 23);
            this.Tabs.Location = new System.Drawing.Point(3, 171);
            this.Tabs.Multiline = true;
            this.Tabs.Name = "Tabs";
            this.Tabs.Padding = new System.Drawing.Point(14, 3);
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(794, 254);
            this.Tabs.TabIndex = 17;
            // 
            // UsersTab
            // 
            this.UsersTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.UsersTab.Controls.Add(this.toolStrip3);
            this.UsersTab.Controls.Add(this.toolStrip2);
            this.UsersTab.Controls.Add(this.UsersDataGrid);
            this.UsersTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.UsersTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UsersTab.Location = new System.Drawing.Point(4, 27);
            this.UsersTab.Name = "UsersTab";
            this.UsersTab.Padding = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.UsersTab.Size = new System.Drawing.Size(786, 223);
            this.UsersTab.TabIndex = 0;
            this.UsersTab.Text = "Users";
            this.UsersTab.ToolTipText = "Users Data";
            // 
            // toolStrip3
            // 
            this.toolStrip3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsersTabSearchLbl,
            this.UsersTabSearchTxt});
            this.toolStrip3.Location = new System.Drawing.Point(3, 1);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip3.Size = new System.Drawing.Size(217, 25);
            this.toolStrip3.TabIndex = 12;
            this.toolStrip3.Text = "toolStrip1";
            // 
            // UsersTabSearchLbl
            // 
            this.UsersTabSearchLbl.Name = "UsersTabSearchLbl";
            this.UsersTabSearchLbl.Size = new System.Drawing.Size(42, 22);
            this.UsersTabSearchLbl.Text = "Buscar";
            // 
            // UsersTabSearchTxt
            // 
            this.UsersTabSearchTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsersTabSearchTxt.Name = "UsersTabSearchTxt";
            this.UsersTabSearchTxt.Size = new System.Drawing.Size(170, 25);
            this.UsersTabSearchTxt.TextChanged += new System.EventHandler(this.UsersTabSearchTxt_TextChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportDataBtn,
            this.ExportAsBtn,
            this.toolStripSeparator1,
            this.ClearEntriesBtn,
            this.EditUserBtn,
            this.RemoveUserBtn,
            this.ViewPDFBtn,
            this.toolStripSeparator6,
            this.NumRowsCb,
            this.GetUsersBtn});
            this.toolStrip2.Location = new System.Drawing.Point(503, 1);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(280, 25);
            this.toolStrip2.TabIndex = 11;
            this.toolStrip2.Text = "toolStrip1";
            // 
            // ImportDataBtn
            // 
            this.ImportDataBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ImportDataBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVFilecsvToolStripMenuItem1,
            this.jSONDataFileToolStripMenuItem,
            this.xMLDocumentxmlToolStripMenuItem1});
            this.ImportDataBtn.Image = ((System.Drawing.Image)(resources.GetObject("ImportDataBtn.Image")));
            this.ImportDataBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ImportDataBtn.Name = "ImportDataBtn";
            this.ImportDataBtn.Size = new System.Drawing.Size(29, 22);
            this.ImportDataBtn.Text = "Import data from";
            // 
            // cSVFilecsvToolStripMenuItem1
            // 
            this.cSVFilecsvToolStripMenuItem1.Name = "cSVFilecsvToolStripMenuItem1";
            this.cSVFilecsvToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.cSVFilecsvToolStripMenuItem1.Text = "CSV File (.csv)";
            // 
            // jSONDataFileToolStripMenuItem
            // 
            this.jSONDataFileToolStripMenuItem.Name = "jSONDataFileToolStripMenuItem";
            this.jSONDataFileToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.jSONDataFileToolStripMenuItem.Text = "JSON Data File (.json)";
            // 
            // xMLDocumentxmlToolStripMenuItem1
            // 
            this.xMLDocumentxmlToolStripMenuItem1.Name = "xMLDocumentxmlToolStripMenuItem1";
            this.xMLDocumentxmlToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.xMLDocumentxmlToolStripMenuItem1.Text = "XML Document (.xml)";
            // 
            // ExportAsBtn
            // 
            this.ExportAsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExportAsBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDFReportToolStripMenuItem,
            this.excelDocumentxlsxToolStripMenuItem,
            this.cSVFilecsvToolStripMenuItem,
            this.xMLDocumentxmlToolStripMenuItem,
            this.hTMLDocumenthtmlToolStripMenuItem,
            this.sQLDatasqlToolStripMenuItem,
            this.jSONDataFilejsonToolStripMenuItem,
            this.textDocumenttxtToolStripMenuItem});
            this.ExportAsBtn.Enabled = false;
            this.ExportAsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExportAsBtn.Image")));
            this.ExportAsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportAsBtn.Name = "ExportAsBtn";
            this.ExportAsBtn.Size = new System.Drawing.Size(29, 22);
            this.ExportAsBtn.Text = "Export data as";
            // 
            // pDFReportToolStripMenuItem
            // 
            this.pDFReportToolStripMenuItem.Image = global::MyCSharpApp.Desktop.Properties.Resources.pdf_file_16x16;
            this.pDFReportToolStripMenuItem.Name = "pDFReportToolStripMenuItem";
            this.pDFReportToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.pDFReportToolStripMenuItem.Text = "PDF Report (.pdf)";
            // 
            // excelDocumentxlsxToolStripMenuItem
            // 
            this.excelDocumentxlsxToolStripMenuItem.Name = "excelDocumentxlsxToolStripMenuItem";
            this.excelDocumentxlsxToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.excelDocumentxlsxToolStripMenuItem.Text = "Excel Document (.xlsx)";
            // 
            // cSVFilecsvToolStripMenuItem
            // 
            this.cSVFilecsvToolStripMenuItem.Name = "cSVFilecsvToolStripMenuItem";
            this.cSVFilecsvToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.cSVFilecsvToolStripMenuItem.Text = "CSV File (.csv)";
            // 
            // xMLDocumentxmlToolStripMenuItem
            // 
            this.xMLDocumentxmlToolStripMenuItem.Name = "xMLDocumentxmlToolStripMenuItem";
            this.xMLDocumentxmlToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.xMLDocumentxmlToolStripMenuItem.Text = "XML Document (.xml)";
            // 
            // hTMLDocumenthtmlToolStripMenuItem
            // 
            this.hTMLDocumenthtmlToolStripMenuItem.Name = "hTMLDocumenthtmlToolStripMenuItem";
            this.hTMLDocumenthtmlToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.hTMLDocumenthtmlToolStripMenuItem.Text = "HTML Document (.html)";
            // 
            // sQLDatasqlToolStripMenuItem
            // 
            this.sQLDatasqlToolStripMenuItem.Name = "sQLDatasqlToolStripMenuItem";
            this.sQLDatasqlToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.sQLDatasqlToolStripMenuItem.Text = "SQL Data (.sql)";
            // 
            // jSONDataFilejsonToolStripMenuItem
            // 
            this.jSONDataFilejsonToolStripMenuItem.Name = "jSONDataFilejsonToolStripMenuItem";
            this.jSONDataFilejsonToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.jSONDataFilejsonToolStripMenuItem.Text = "JSON Data File (.json)";
            // 
            // textDocumenttxtToolStripMenuItem
            // 
            this.textDocumenttxtToolStripMenuItem.Name = "textDocumenttxtToolStripMenuItem";
            this.textDocumenttxtToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.textDocumenttxtToolStripMenuItem.Text = "Text Document (.txt)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ClearEntriesBtn
            // 
            this.ClearEntriesBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearEntriesBtn.Enabled = false;
            this.ClearEntriesBtn.Image = global::MyCSharpApp.Desktop.Properties.Resources.DeleteTable_16x;
            this.ClearEntriesBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearEntriesBtn.Name = "ClearEntriesBtn";
            this.ClearEntriesBtn.Size = new System.Drawing.Size(23, 22);
            this.ClearEntriesBtn.Text = "Clear entries";
            this.ClearEntriesBtn.Click += new System.EventHandler(this.ClearEntriesBtn_Click);
            // 
            // EditUserBtn
            // 
            this.EditUserBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditUserBtn.Enabled = false;
            this.EditUserBtn.Image = global::MyCSharpApp.Desktop.Properties.Resources._126_Edit_16x16_72;
            this.EditUserBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditUserBtn.Name = "EditUserBtn";
            this.EditUserBtn.Size = new System.Drawing.Size(23, 22);
            this.EditUserBtn.Text = "Edit User";
            // 
            // RemoveUserBtn
            // 
            this.RemoveUserBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveUserBtn.Enabled = false;
            this.RemoveUserBtn.Image = global::MyCSharpApp.Desktop.Properties.Resources.delete_12x12;
            this.RemoveUserBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveUserBtn.Name = "RemoveUserBtn";
            this.RemoveUserBtn.Size = new System.Drawing.Size(23, 22);
            this.RemoveUserBtn.Text = "Remove User";
            this.RemoveUserBtn.Click += new System.EventHandler(this.RemoveUserBtn_Click);
            // 
            // ViewPDFBtn
            // 
            this.ViewPDFBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ViewPDFBtn.Enabled = false;
            this.ViewPDFBtn.Image = global::MyCSharpApp.Desktop.Properties.Resources.pdf_file_16x16;
            this.ViewPDFBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ViewPDFBtn.Name = "ViewPDFBtn";
            this.ViewPDFBtn.Size = new System.Drawing.Size(23, 22);
            this.ViewPDFBtn.Text = "View in report";
            this.ViewPDFBtn.Click += new System.EventHandler(this.ViewPDFBtn_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // NumRowsCb
            // 
            this.NumRowsCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumRowsCb.Items.AddRange(new object[] {
            "All",
            "10",
            "25",
            "50",
            "100",
            "250",
            "500",
            "1000",
            "5000",
            "10000",
            "100000"});
            this.NumRowsCb.Name = "NumRowsCb";
            this.NumRowsCb.Size = new System.Drawing.Size(90, 25);
            this.NumRowsCb.ToolTipText = "Num rows";
            // 
            // GetUsersBtn
            // 
            this.GetUsersBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GetUsersBtn.Image = global::MyCSharpApp.Desktop.Properties.Resources._010_LowPriority_16x16_72;
            this.GetUsersBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GetUsersBtn.Name = "GetUsersBtn";
            this.GetUsersBtn.Size = new System.Drawing.Size(23, 22);
            this.GetUsersBtn.Text = "Get Users";
            this.GetUsersBtn.Click += new System.EventHandler(this.GetUsersBtn_Click);
            // 
            // UsersDataGrid
            // 
            this.UsersDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.UsersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGrid.Location = new System.Drawing.Point(0, 29);
            this.UsersDataGrid.Name = "UsersDataGrid";
            this.UsersDataGrid.Size = new System.Drawing.Size(786, 194);
            this.UsersDataGrid.TabIndex = 4;
            this.UsersDataGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.UsersDataGrid_DataError);
            // 
            // ProductsTab
            // 
            this.ProductsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ProductsTab.Controls.Add(this.GetProductsBtn);
            this.ProductsTab.Controls.Add(this.ProductsDataGrid);
            this.ProductsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ProductsTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProductsTab.Location = new System.Drawing.Point(4, 27);
            this.ProductsTab.Name = "ProductsTab";
            this.ProductsTab.Padding = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.ProductsTab.Size = new System.Drawing.Size(786, 223);
            this.ProductsTab.TabIndex = 1;
            this.ProductsTab.Text = "Products";
            this.ProductsTab.ToolTipText = "Products Data";
            // 
            // GetProductsBtn
            // 
            this.GetProductsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetProductsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetProductsBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GetProductsBtn.Location = new System.Drawing.Point(681, 3);
            this.GetProductsBtn.Name = "GetProductsBtn";
            this.GetProductsBtn.Size = new System.Drawing.Size(102, 23);
            this.GetProductsBtn.TabIndex = 12;
            this.GetProductsBtn.Text = "Get Products";
            this.GetProductsBtn.UseVisualStyleBackColor = true;
            this.GetProductsBtn.Click += new System.EventHandler(this.GetProductsBtn_Click);
            // 
            // ProductsDataGrid
            // 
            this.ProductsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.ProductsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGrid.Location = new System.Drawing.Point(0, 29);
            this.ProductsDataGrid.Name = "ProductsDataGrid";
            this.ProductsDataGrid.Size = new System.Drawing.Size(786, 194);
            this.ProductsDataGrid.TabIndex = 11;
            // 
            // CreateUserGB
            // 
            this.CreateUserGB.Controls.Add(this.VerifiedChk);
            this.CreateUserGB.Controls.Add(this.CancelBtn);
            this.CreateUserGB.Controls.Add(this.CreateBtn);
            this.CreateUserGB.Controls.Add(this.BirthDateTxt);
            this.CreateUserGB.Controls.Add(this.BirthDateLbl);
            this.CreateUserGB.Controls.Add(this.EmailTxt);
            this.CreateUserGB.Controls.Add(this.label2);
            this.CreateUserGB.Controls.Add(this.AgeTxt);
            this.CreateUserGB.Controls.Add(this.AgeLbl);
            this.CreateUserGB.Controls.Add(this.UserGenreGB);
            this.CreateUserGB.Controls.Add(this.LastnameTxt);
            this.CreateUserGB.Controls.Add(this.LastnameLbl);
            this.CreateUserGB.Controls.Add(this.FirstnameTxt);
            this.CreateUserGB.Controls.Add(this.FirstnameLbl);
            this.CreateUserGB.Controls.Add(this.UsernameTxt);
            this.CreateUserGB.Controls.Add(this.UsernameLbl);
            this.CreateUserGB.Location = new System.Drawing.Point(3, 2);
            this.CreateUserGB.Name = "CreateUserGB";
            this.CreateUserGB.Size = new System.Drawing.Size(445, 163);
            this.CreateUserGB.TabIndex = 18;
            this.CreateUserGB.TabStop = false;
            this.CreateUserGB.Text = "Create User";
            // 
            // VerifiedChk
            // 
            this.VerifiedChk.AutoSize = true;
            this.VerifiedChk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.VerifiedChk.Location = new System.Drawing.Point(67, 133);
            this.VerifiedChk.Name = "VerifiedChk";
            this.VerifiedChk.Size = new System.Drawing.Size(61, 17);
            this.VerifiedChk.TabIndex = 5;
            this.VerifiedChk.Text = "Verified";
            this.VerifiedChk.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CancelBtn.Location = new System.Drawing.Point(243, 133);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(95, 23);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CreateBtn.Location = new System.Drawing.Point(344, 133);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(95, 23);
            this.CreateBtn.TabIndex = 10;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // BirthDateTxt
            // 
            this.BirthDateTxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDateTxt.Location = new System.Drawing.Point(277, 103);
            this.BirthDateTxt.Name = "BirthDateTxt";
            this.BirthDateTxt.Size = new System.Drawing.Size(162, 20);
            this.BirthDateTxt.TabIndex = 8;
            this.BirthDateTxt.ValueChanged += new System.EventHandler(this.BirthDateTxt_ValueChanged);
            // 
            // BirthDateLbl
            // 
            this.BirthDateLbl.AutoSize = true;
            this.BirthDateLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BirthDateLbl.Location = new System.Drawing.Point(216, 106);
            this.BirthDateLbl.Name = "BirthDateLbl";
            this.BirthDateLbl.Size = new System.Drawing.Size(54, 13);
            this.BirthDateLbl.TabIndex = 12;
            this.BirthDateLbl.Text = "Birth Date";
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(67, 103);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(143, 20);
            this.EmailTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(29, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email";
            // 
            // AgeTxt
            // 
            this.AgeTxt.Enabled = false;
            this.AgeTxt.Location = new System.Drawing.Point(277, 75);
            this.AgeTxt.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.AgeTxt.Name = "AgeTxt";
            this.AgeTxt.Size = new System.Drawing.Size(80, 20);
            this.AgeTxt.TabIndex = 7;
            // 
            // AgeLbl
            // 
            this.AgeLbl.AutoSize = true;
            this.AgeLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AgeLbl.Location = new System.Drawing.Point(244, 77);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(26, 13);
            this.AgeLbl.TabIndex = 8;
            this.AgeLbl.Text = "Age";
            // 
            // UserGenreGB
            // 
            this.UserGenreGB.BackColor = System.Drawing.SystemColors.Control;
            this.UserGenreGB.Controls.Add(this.FemaleRadioBtn);
            this.UserGenreGB.Controls.Add(this.MaleRadioBtn);
            this.UserGenreGB.Location = new System.Drawing.Point(216, 19);
            this.UserGenreGB.Name = "UserGenreGB";
            this.UserGenreGB.Size = new System.Drawing.Size(223, 49);
            this.UserGenreGB.TabIndex = 6;
            this.UserGenreGB.TabStop = false;
            this.UserGenreGB.Text = "Genre";
            // 
            // FemaleRadioBtn
            // 
            this.FemaleRadioBtn.AutoSize = true;
            this.FemaleRadioBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FemaleRadioBtn.Location = new System.Drawing.Point(111, 19);
            this.FemaleRadioBtn.Name = "FemaleRadioBtn";
            this.FemaleRadioBtn.Size = new System.Drawing.Size(59, 17);
            this.FemaleRadioBtn.TabIndex = 6;
            this.FemaleRadioBtn.TabStop = true;
            this.FemaleRadioBtn.Text = "Female";
            this.FemaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // MaleRadioBtn
            // 
            this.MaleRadioBtn.AutoSize = true;
            this.MaleRadioBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaleRadioBtn.Location = new System.Drawing.Point(31, 19);
            this.MaleRadioBtn.Name = "MaleRadioBtn";
            this.MaleRadioBtn.Size = new System.Drawing.Size(48, 17);
            this.MaleRadioBtn.TabIndex = 6;
            this.MaleRadioBtn.TabStop = true;
            this.MaleRadioBtn.Text = "Male";
            this.MaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // LastnameTxt
            // 
            this.LastnameTxt.Location = new System.Drawing.Point(67, 74);
            this.LastnameTxt.Name = "LastnameTxt";
            this.LastnameTxt.Size = new System.Drawing.Size(143, 20);
            this.LastnameTxt.TabIndex = 3;
            // 
            // LastnameLbl
            // 
            this.LastnameLbl.AutoSize = true;
            this.LastnameLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LastnameLbl.Location = new System.Drawing.Point(9, 76);
            this.LastnameLbl.Name = "LastnameLbl";
            this.LastnameLbl.Size = new System.Drawing.Size(53, 13);
            this.LastnameLbl.TabIndex = 4;
            this.LastnameLbl.Text = "Lastname";
            // 
            // FirstnameTxt
            // 
            this.FirstnameTxt.Location = new System.Drawing.Point(67, 48);
            this.FirstnameTxt.Name = "FirstnameTxt";
            this.FirstnameTxt.Size = new System.Drawing.Size(143, 20);
            this.FirstnameTxt.TabIndex = 2;
            // 
            // FirstnameLbl
            // 
            this.FirstnameLbl.AutoSize = true;
            this.FirstnameLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FirstnameLbl.Location = new System.Drawing.Point(9, 51);
            this.FirstnameLbl.Name = "FirstnameLbl";
            this.FirstnameLbl.Size = new System.Drawing.Size(52, 13);
            this.FirstnameLbl.TabIndex = 2;
            this.FirstnameLbl.Text = "Firstname";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Location = new System.Drawing.Point(67, 22);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(143, 20);
            this.UsernameTxt.TabIndex = 1;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UsernameLbl.Location = new System.Drawing.Point(9, 25);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(55, 13);
            this.UsernameLbl.TabIndex = 0;
            this.UsernameLbl.Text = "Username";
            // 
            // DllMessageBtn
            // 
            this.DllMessageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DllMessageBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DllMessageBtn.Location = new System.Drawing.Point(684, 2);
            this.DllMessageBtn.Name = "DllMessageBtn";
            this.DllMessageBtn.Size = new System.Drawing.Size(115, 23);
            this.DllMessageBtn.TabIndex = 19;
            this.DllMessageBtn.Text = "Dll Message";
            this.DllMessageBtn.UseVisualStyleBackColor = true;
            this.DllMessageBtn.Click += new System.EventHandler(this.DllMessageBtn_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // MainPanelStatusBar
            // 
            this.MainPanelStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripSeparator2,
            this.toolStripStatusLabel2,
            this.toolStripLabel1,
            this.toolStripProgressBar1,
            this.toolStripSeparator3});
            this.MainPanelStatusBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MainPanelStatusBar.Location = new System.Drawing.Point(0, 427);
            this.MainPanelStatusBar.Name = "MainPanelStatusBar";
            this.MainPanelStatusBar.Size = new System.Drawing.Size(800, 23);
            this.MainPanelStatusBar.SizingGrip = false;
            this.MainPanelStatusBar.TabIndex = 20;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 18);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(70, 18);
            this.toolStripStatusLabel2.Text = "Rows: 0 of 0";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(23, 21);
            this.toolStripLabel1.Text = "0%";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(120, 17);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanelStatusBar);
            this.Controls.Add(this.DllMessageBtn);
            this.Controls.Add(this.CreateUserGB);
            this.Controls.Add(this.Tabs);
            this.Name = "MainPanel";
            this.Text = "MainPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPanel_FormClosing);
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.Tabs.ResumeLayout(false);
            this.UsersTab.ResumeLayout(false);
            this.UsersTab.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).EndInit();
            this.ProductsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).EndInit();
            this.CreateUserGB.ResumeLayout(false);
            this.CreateUserGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeTxt)).EndInit();
            this.UserGenreGB.ResumeLayout(false);
            this.UserGenreGB.PerformLayout();
            this.MainPanelStatusBar.ResumeLayout(false);
            this.MainPanelStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage UsersTab;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel UsersTabSearchLbl;
        private System.Windows.Forms.ToolStripTextBox UsersTabSearchTxt;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton EditUserBtn;
        private System.Windows.Forms.ToolStripButton RemoveUserBtn;
        private System.Windows.Forms.ToolStripButton GetUsersBtn;
        private System.Windows.Forms.DataGridView UsersDataGrid;
        private System.Windows.Forms.TabPage ProductsTab;
        private System.Windows.Forms.Button GetProductsBtn;
        private System.Windows.Forms.DataGridView ProductsDataGrid;
        private System.Windows.Forms.GroupBox CreateUserGB;
        private System.Windows.Forms.CheckBox VerifiedChk;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.DateTimePicker BirthDateTxt;
        private System.Windows.Forms.Label BirthDateLbl;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown AgeTxt;
        private System.Windows.Forms.Label AgeLbl;
        private System.Windows.Forms.GroupBox UserGenreGB;
        private System.Windows.Forms.RadioButton FemaleRadioBtn;
        private System.Windows.Forms.RadioButton MaleRadioBtn;
        private System.Windows.Forms.TextBox LastnameTxt;
        private System.Windows.Forms.Label LastnameLbl;
        private System.Windows.Forms.TextBox FirstnameTxt;
        private System.Windows.Forms.Label FirstnameLbl;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Button DllMessageBtn;
        private System.Windows.Forms.ToolStripButton ClearEntriesBtn;
        private System.Windows.Forms.ToolStripButton ViewPDFBtn;
        private System.Windows.Forms.ToolStripMenuItem excelDocumentxlsxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVFilecsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLDocumentxmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTMLDocumenthtmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLDatasqlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONDataFilejsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textDocumenttxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton ExportAsBtn;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton ImportDataBtn;
        private System.Windows.Forms.ToolStripMenuItem cSVFilecsvToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jSONDataFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLDocumentxmlToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox NumRowsCb;
        private System.Windows.Forms.StatusStrip MainPanelStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}