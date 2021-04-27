
namespace ATAPP_XML
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.flpButtonData = new System.Windows.Forms.FlowLayoutPanel();
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.importerUnCoffreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterUnCoffreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.séléctionnerToutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpButtonData
            // 
            this.flpButtonData.Location = new System.Drawing.Point(1, 55);
            this.flpButtonData.Name = "flpButtonData";
            this.flpButtonData.Size = new System.Drawing.Size(882, 691);
            this.flpButtonData.TabIndex = 1;
            this.flpButtonData.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flpButtonData_ControlAdded);
            // 
            // mspMenu
            // 
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Size = new System.Drawing.Size(883, 24);
            this.mspMenu.TabIndex = 3;
            this.mspMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.toolStripSeparator2,
            this.importerUnCoffreToolStripMenuItem,
            this.exporterUnCoffreToolStripMenuItem,
            this.toolStripSeparator3,
            this.quitterToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fileToolStripMenuItem.Text = "Fichier";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterToolStripMenuItem.Text = "Nouveau";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // importerUnCoffreToolStripMenuItem
            // 
            this.importerUnCoffreToolStripMenuItem.Name = "importerUnCoffreToolStripMenuItem";
            this.importerUnCoffreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importerUnCoffreToolStripMenuItem.Text = "Importer un coffre...";
            // 
            // exporterUnCoffreToolStripMenuItem
            // 
            this.exporterUnCoffreToolStripMenuItem.Name = "exporterUnCoffreToolStripMenuItem";
            this.exporterUnCoffreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exporterUnCoffreToolStripMenuItem.Text = "Exporter un coffre...";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copierToolStripMenuItem,
            this.couperToolStripMenuItem,
            this.collerToolStripMenuItem,
            this.toolStripSeparator1,
            this.séléctionnerToutToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editToolStripMenuItem.Text = "Edition";
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.copierToolStripMenuItem.Text = "Copier";
            // 
            // couperToolStripMenuItem
            // 
            this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            this.couperToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.couperToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.couperToolStripMenuItem.Text = "Couper";
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.collerToolStripMenuItem.Text = "Coller";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // séléctionnerToutToolStripMenuItem
            // 
            this.séléctionnerToutToolStripMenuItem.Name = "séléctionnerToutToolStripMenuItem";
            this.séléctionnerToutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.séléctionnerToutToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.séléctionnerToutToolStripMenuItem.Text = "Séléctionner tout";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 745);
            this.Controls.Add(this.flpButtonData);
            this.Controls.Add(this.mspMenu);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mspMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpButtonData;
        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem séléctionnerToutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem importerUnCoffreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterUnCoffreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}