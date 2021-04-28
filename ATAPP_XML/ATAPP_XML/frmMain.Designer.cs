
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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxTitre = new System.Windows.Forms.PictureBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnSites = new System.Windows.Forms.Button();
            this.btnLogiciels = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitre)).BeginInit();
            this.SuspendLayout();
            // 
            // flpButtonData
            // 
            this.flpButtonData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flpButtonData.Location = new System.Drawing.Point(175, 0);
            this.flpButtonData.Margin = new System.Windows.Forms.Padding(0);
            this.flpButtonData.Name = "flpButtonData";
            this.flpButtonData.Padding = new System.Windows.Forms.Padding(5);
            this.flpButtonData.Size = new System.Drawing.Size(702, 746);
            this.flpButtonData.TabIndex = 1;
            this.flpButtonData.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flpButtonData_ControlAdded);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuitter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuitter.Location = new System.Drawing.Point(0, 684);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(175, 62);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.btnLogiciels);
            this.panel1.Controls.Add(this.btnSites);
            this.panel1.Controls.Add(this.btnNouveau);
            this.panel1.Controls.Add(this.btnAccueil);
            this.panel1.Controls.Add(this.lblTitre);
            this.panel1.Controls.Add(this.pbxTitre);
            this.panel1.Controls.Add(this.btnQuitter);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 746);
            this.panel1.TabIndex = 6;
            // 
            // pbxTitre
            // 
            this.pbxTitre.Image = global::ATAPP_XML.Properties.Resources.icons8_livres_100;
            this.pbxTitre.Location = new System.Drawing.Point(3, 3);
            this.pbxTitre.Name = "pbxTitre";
            this.pbxTitre.Size = new System.Drawing.Size(45, 47);
            this.pbxTitre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTitre.TabIndex = 6;
            this.pbxTitre.TabStop = false;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitre.Location = new System.Drawing.Point(44, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(128, 31);
            this.lblTitre.TabIndex = 7;
            this.lblTitre.Text = "Biblio-tech";
            // 
            // btnAccueil
            // 
            this.btnAccueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.btnAccueil.FlatAppearance.BorderSize = 0;
            this.btnAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccueil.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAccueil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAccueil.Location = new System.Drawing.Point(0, 73);
            this.btnAccueil.Margin = new System.Windows.Forms.Padding(0);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(175, 34);
            this.btnAccueil.TabIndex = 8;
            this.btnAccueil.Text = "Accueil";
            this.btnAccueil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccueil.UseVisualStyleBackColor = false;
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.btnNouveau.FlatAppearance.BorderSize = 0;
            this.btnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouveau.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnNouveau.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNouveau.Location = new System.Drawing.Point(0, 107);
            this.btnNouveau.Margin = new System.Windows.Forms.Padding(0);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(175, 34);
            this.btnNouveau.TabIndex = 9;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnSites
            // 
            this.btnSites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.btnSites.FlatAppearance.BorderSize = 0;
            this.btnSites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSites.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnSites.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSites.Location = new System.Drawing.Point(-3, 141);
            this.btnSites.Margin = new System.Windows.Forms.Padding(0);
            this.btnSites.Name = "btnSites";
            this.btnSites.Size = new System.Drawing.Size(175, 34);
            this.btnSites.TabIndex = 10;
            this.btnSites.Text = "Sites";
            this.btnSites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSites.UseVisualStyleBackColor = false;
            // 
            // btnLogiciels
            // 
            this.btnLogiciels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.btnLogiciels.FlatAppearance.BorderSize = 0;
            this.btnLogiciels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogiciels.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogiciels.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogiciels.Location = new System.Drawing.Point(0, 175);
            this.btnLogiciels.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogiciels.Name = "btnLogiciels";
            this.btnLogiciels.Size = new System.Drawing.Size(175, 34);
            this.btnLogiciels.TabIndex = 11;
            this.btnLogiciels.Text = "Logiciels";
            this.btnLogiciels.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogiciels.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 745);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpButtonData);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpButtonData;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.PictureBox pbxTitre;
        private System.Windows.Forms.Button btnLogiciels;
        private System.Windows.Forms.Button btnSites;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnAccueil;
    }
}