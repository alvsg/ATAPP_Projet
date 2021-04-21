
namespace ATAPP_XML
{
    partial class frmCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreation));
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblMessageSignUp = new System.Windows.Forms.Label();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.tbxNewPwd = new System.Windows.Forms.TextBox();
            this.lblConfNewPwd = new System.Windows.Forms.Label();
            this.tbxConfNewPwd = new System.Windows.Forms.TextBox();
            this.btnSetPwd = new System.Windows.Forms.Button();
            this.lblMessageError = new System.Windows.Forms.Label();
            this.cbxRandomPassword = new System.Windows.Forms.CheckBox();
            this.pbxIconMessage = new System.Windows.Forms.PictureBox();
            this.pbxNewPwd = new System.Windows.Forms.PictureBox();
            this.pbxConfPwd = new System.Windows.Forms.PictureBox();
            this.pbxIconNewUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNewPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConfPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconNewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Arial", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.Location = new System.Drawing.Point(117, 21);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(322, 60);
            this.lblSignUp.TabIndex = 2;
            this.lblSignUp.Text = "S\'enregistrer";
            // 
            // lblMessageSignUp
            // 
            this.lblMessageSignUp.AutoSize = true;
            this.lblMessageSignUp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageSignUp.Location = new System.Drawing.Point(125, 81);
            this.lblMessageSignUp.Name = "lblMessageSignUp";
            this.lblMessageSignUp.Size = new System.Drawing.Size(260, 16);
            this.lblMessageSignUp.TabIndex = 4;
            this.lblMessageSignUp.Text = "Veuillez remplir ce formulaire pour continuer";
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblNewPwd.Location = new System.Drawing.Point(9, 144);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(148, 16);
            this.lblNewPwd.TabIndex = 5;
            this.lblNewPwd.Text = "Nouveau mot de passe :";
            // 
            // tbxNewPwd
            // 
            this.tbxNewPwd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxNewPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNewPwd.Location = new System.Drawing.Point(160, 145);
            this.tbxNewPwd.Name = "tbxNewPwd";
            this.tbxNewPwd.PasswordChar = '*';
            this.tbxNewPwd.Size = new System.Drawing.Size(252, 20);
            this.tbxNewPwd.TabIndex = 6;
            this.tbxNewPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxNewPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxKeyDown);
            // 
            // lblConfNewPwd
            // 
            this.lblConfNewPwd.AutoSize = true;
            this.lblConfNewPwd.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblConfNewPwd.Location = new System.Drawing.Point(55, 182);
            this.lblConfNewPwd.Name = "lblConfNewPwd";
            this.lblConfNewPwd.Size = new System.Drawing.Size(92, 16);
            this.lblConfNewPwd.TabIndex = 7;
            this.lblConfNewPwd.Text = "Confirmation  :";
            // 
            // tbxConfNewPwd
            // 
            this.tbxConfNewPwd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxConfNewPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxConfNewPwd.Location = new System.Drawing.Point(160, 180);
            this.tbxConfNewPwd.Name = "tbxConfNewPwd";
            this.tbxConfNewPwd.PasswordChar = '*';
            this.tbxConfNewPwd.Size = new System.Drawing.Size(252, 20);
            this.tbxConfNewPwd.TabIndex = 8;
            this.tbxConfNewPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxConfNewPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxKeyDown);
            // 
            // btnSetPwd
            // 
            this.btnSetPwd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSetPwd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSetPwd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPwd.Location = new System.Drawing.Point(337, 239);
            this.btnSetPwd.Name = "btnSetPwd";
            this.btnSetPwd.Size = new System.Drawing.Size(102, 23);
            this.btnSetPwd.TabIndex = 9;
            this.btnSetPwd.Text = "Apply";
            this.btnSetPwd.UseVisualStyleBackColor = false;
            this.btnSetPwd.Click += new System.EventHandler(this.btnSetPwd_Click);
            // 
            // lblMessageError
            // 
            this.lblMessageError.AutoSize = true;
            this.lblMessageError.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblMessageError.ForeColor = System.Drawing.Color.Black;
            this.lblMessageError.Location = new System.Drawing.Point(34, 244);
            this.lblMessageError.Name = "lblMessageError";
            this.lblMessageError.Size = new System.Drawing.Size(246, 16);
            this.lblMessageError.TabIndex = 10;
            this.lblMessageError.Text = "Les deux champs ne sont pas identique !";
            this.lblMessageError.Visible = false;
            // 
            // cbxRandomPassword
            // 
            this.cbxRandomPassword.AutoSize = true;
            this.cbxRandomPassword.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbxRandomPassword.Location = new System.Drawing.Point(160, 206);
            this.cbxRandomPassword.Name = "cbxRandomPassword";
            this.cbxRandomPassword.Size = new System.Drawing.Size(244, 20);
            this.cbxRandomPassword.TabIndex = 15;
            this.cbxRandomPassword.Text = "Génération de mot de passe aléatoire";
            this.cbxRandomPassword.UseVisualStyleBackColor = true;
            this.cbxRandomPassword.CheckedChanged += new System.EventHandler(this.cbxRandomPassword_CheckedChanged);
            // 
            // pbxIconMessage
            // 
            this.pbxIconMessage.Image = global::ATAPP_XML.Properties.Resources.icons8_warning_48;
            this.pbxIconMessage.Location = new System.Drawing.Point(7, 241);
            this.pbxIconMessage.Name = "pbxIconMessage";
            this.pbxIconMessage.Size = new System.Drawing.Size(21, 21);
            this.pbxIconMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIconMessage.TabIndex = 16;
            this.pbxIconMessage.TabStop = false;
            this.pbxIconMessage.Visible = false;
            // 
            // pbxNewPwd
            // 
            this.pbxNewPwd.Image = global::ATAPP_XML.Properties.Resources.icons8_invisible_24;
            this.pbxNewPwd.Location = new System.Drawing.Point(418, 144);
            this.pbxNewPwd.Name = "pbxNewPwd";
            this.pbxNewPwd.Size = new System.Drawing.Size(21, 21);
            this.pbxNewPwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxNewPwd.TabIndex = 12;
            this.pbxNewPwd.TabStop = false;
            this.pbxNewPwd.Click += new System.EventHandler(this.PbxClicked);
            // 
            // pbxConfPwd
            // 
            this.pbxConfPwd.Image = global::ATAPP_XML.Properties.Resources.icons8_invisible_24;
            this.pbxConfPwd.Location = new System.Drawing.Point(418, 179);
            this.pbxConfPwd.Name = "pbxConfPwd";
            this.pbxConfPwd.Size = new System.Drawing.Size(21, 21);
            this.pbxConfPwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxConfPwd.TabIndex = 11;
            this.pbxConfPwd.TabStop = false;
            this.pbxConfPwd.Click += new System.EventHandler(this.PbxClicked);
            // 
            // pbxIconNewUser
            // 
            this.pbxIconNewUser.Location = new System.Drawing.Point(12, 12);
            this.pbxIconNewUser.Name = "pbxIconNewUser";
            this.pbxIconNewUser.Size = new System.Drawing.Size(100, 95);
            this.pbxIconNewUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxIconNewUser.TabIndex = 3;
            this.pbxIconNewUser.TabStop = false;
            // 
            // frmCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 277);
            this.Controls.Add(this.pbxIconMessage);
            this.Controls.Add(this.cbxRandomPassword);
            this.Controls.Add(this.pbxNewPwd);
            this.Controls.Add(this.pbxConfPwd);
            this.Controls.Add(this.lblMessageError);
            this.Controls.Add(this.btnSetPwd);
            this.Controls.Add(this.tbxConfNewPwd);
            this.Controls.Add(this.lblConfNewPwd);
            this.Controls.Add(this.tbxNewPwd);
            this.Controls.Add(this.lblNewPwd);
            this.Controls.Add(this.lblMessageSignUp);
            this.Controls.Add(this.pbxIconNewUser);
            this.Controls.Add(this.lblSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblio-tech";
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNewPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConfPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconNewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblMessageSignUp;
        private System.Windows.Forms.PictureBox pbxIconNewUser;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.TextBox tbxNewPwd;
        private System.Windows.Forms.Label lblConfNewPwd;
        private System.Windows.Forms.TextBox tbxConfNewPwd;
        private System.Windows.Forms.Button btnSetPwd;
        private System.Windows.Forms.Label lblMessageError;
        private System.Windows.Forms.PictureBox pbxConfPwd;
        private System.Windows.Forms.PictureBox pbxNewPwd;
        private System.Windows.Forms.CheckBox cbxRandomPassword;
        private System.Windows.Forms.PictureBox pbxIconMessage;
    }
}