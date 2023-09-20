namespace MyCSharpApp.Desktop.Panels
{
    partial class SideBarPanel
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nodo8");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nodo10");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nodo11");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nodo12");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Folders", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Links");
            this.LeftSideBar = new System.Windows.Forms.Panel();
            this.FileTree = new System.Windows.Forms.TreeView();
            this.LeftSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftSideBar
            // 
            this.LeftSideBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftSideBar.BackColor = System.Drawing.SystemColors.Control;
            this.LeftSideBar.Controls.Add(this.FileTree);
            this.LeftSideBar.Location = new System.Drawing.Point(2, 2);
            this.LeftSideBar.Name = "LeftSideBar";
            this.LeftSideBar.Size = new System.Drawing.Size(796, 447);
            this.LeftSideBar.TabIndex = 13;
            // 
            // FileTree
            // 
            this.FileTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileTree.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FileTree.LineColor = System.Drawing.Color.Gainsboro;
            this.FileTree.Location = new System.Drawing.Point(1, 25);
            this.FileTree.Name = "FileTree";
            treeNode1.Name = "Nodo8";
            treeNode1.Text = "Nodo8";
            treeNode2.Name = "Nodo10";
            treeNode2.SelectedImageKey = "(predeterminada)";
            treeNode2.Text = "Nodo10";
            treeNode3.Name = "Nodo11";
            treeNode3.Text = "Nodo11";
            treeNode4.Name = "Nodo12";
            treeNode4.Text = "Nodo12";
            treeNode5.Name = "FoldersNode";
            treeNode5.Text = "Folders";
            treeNode6.Name = "LinksNode";
            treeNode6.Text = "Links";
            this.FileTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            this.FileTree.ShowNodeToolTips = true;
            this.FileTree.Size = new System.Drawing.Size(794, 421);
            this.FileTree.TabIndex = 0;
            // 
            // SideBarPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LeftSideBar);
            this.Name = "SideBarPanel";
            this.Text = "SideBarPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SideBarPanel_FormClosing);
            this.LeftSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftSideBar;
        private System.Windows.Forms.TreeView FileTree;
    }
}