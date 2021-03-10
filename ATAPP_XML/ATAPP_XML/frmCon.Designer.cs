
namespace ATAPP_XML
{
    partial class frmCon
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCon));
            this.lblWelcom = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tbxConPwd = new System.Windows.Forms.TextBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.btnCon = new System.Windows.Forms.Button();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.pbxWarning = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcom
            // 
            this.lblWelcom.AutoSize = true;
            this.lblWelcom.Font = new System.Drawing.Font("Arial", 39.75F);
            this.lblWelcom.Location = new System.Drawing.Point(145, 15);
            this.lblWelcom.Name = "lblWelcom";
            this.lblWelcom.Size = new System.Drawing.Size(268, 60);
            this.lblWelcom.TabIndex = 1;
            this.lblWelcom.Text = "Biblio-tech";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblMessage.Location = new System.Drawing.Point(152, 75);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(290, 16);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Veuillez entrer votre mot de passe pour continuer";
            // 
            // tbxConPwd
            // 
            this.tbxConPwd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxConPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxConPwd.Location = new System.Drawing.Point(37, 124);
            this.tbxConPwd.Name = "tbxConPwd";
            this.tbxConPwd.PasswordChar = '*';
            this.tbxConPwd.Size = new System.Drawing.Size(334, 22);
            this.tbxConPwd.TabIndex = 3;
            this.tbxConPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(197, 165);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(120, 16);
            this.lblExit.TabIndex = 4;
            this.lblExit.Text = "Fermer l\'application";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // btnCon
            // 
            this.btnCon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCon.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnCon.Location = new System.Drawing.Point(377, 123);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(93, 23);
            this.btnCon.TabIndex = 5;
            this.btnCon.Text = "Enter";
            this.btnCon.UseVisualStyleBackColor = false;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // pbxIcon
            // 
            this.pbxIcon.Image = global::ATAPP_XML.Properties.Resources.icons8_livres_100;
            this.pbxIcon.Location = new System.Drawing.Point(37, 12);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(100, 95);
            this.pbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxIcon.TabIndex = 0;
            this.pbxIcon.TabStop = false;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblWarning.Location = new System.Drawing.Point(39, 175);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(127, 16);
            this.lblWarning.TabIndex = 6;
            this.lblWarning.Text = "Mot de passe erroné";
            this.lblWarning.Visible = false;
            // 
            // pbxWarning
            // 
            this.pbxWarning.Image = global::ATAPP_XML.Properties.Resources.icons8_warning_48;
            this.pbxWarning.Location = new System.Drawing.Point(12, 172);
            this.pbxWarning.Name = "pbxWarning";
            this.pbxWarning.Size = new System.Drawing.Size(21, 21);
            this.pbxWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxWarning.TabIndex = 17;
            this.pbxWarning.TabStop = false;
            this.pbxWarning.Visible = false;
            // 
            // frmCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(510, 202);
            this.Controls.Add(this.pbxWarning);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.tbxConPwd);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblWelcom);
            this.Controls.Add(this.pbxIcon);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.frmCon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcom;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox tbxConPwd;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox pbxIcon;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.PictureBox pbxWarning;
    }
}

