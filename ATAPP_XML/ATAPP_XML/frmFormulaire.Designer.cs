
namespace ATAPP_XML
{
    partial class frmFormulaire
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
            this.gbxFormulaire = new System.Windows.Forms.GroupBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.tbxPwd = new System.Windows.Forms.TextBox();
            this.lblPwdT = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblUsernameT = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblNomT = new System.Windows.Forms.Label();
            this.pbxPwdM = new System.Windows.Forms.PictureBox();
            this.cbxRandomPasswordM = new System.Windows.Forms.CheckBox();
            this.gbxFormulaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPwdM)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxFormulaire
            // 
            this.gbxFormulaire.Controls.Add(this.cbxRandomPasswordM);
            this.gbxFormulaire.Controls.Add(this.pbxPwdM);
            this.gbxFormulaire.Controls.Add(this.lblPwd);
            this.gbxFormulaire.Controls.Add(this.lblUsername);
            this.gbxFormulaire.Controls.Add(this.lblName);
            this.gbxFormulaire.Controls.Add(this.btnAction);
            this.gbxFormulaire.Controls.Add(this.btnModify);
            this.gbxFormulaire.Controls.Add(this.tbxPwd);
            this.gbxFormulaire.Controls.Add(this.lblPwdT);
            this.gbxFormulaire.Controls.Add(this.tbxUsername);
            this.gbxFormulaire.Controls.Add(this.lblUsernameT);
            this.gbxFormulaire.Controls.Add(this.tbxName);
            this.gbxFormulaire.Controls.Add(this.lblNomT);
            this.gbxFormulaire.Location = new System.Drawing.Point(13, 13);
            this.gbxFormulaire.Name = "gbxFormulaire";
            this.gbxFormulaire.Size = new System.Drawing.Size(363, 171);
            this.gbxFormulaire.TabIndex = 0;
            this.gbxFormulaire.TabStop = false;
            this.gbxFormulaire.Text = "Information";
//            this.gbxFormulaire.Enter += new System.EventHandler(this.gbxFormulaire_Enter);
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(113, 82);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(0, 13);
            this.lblPwd.TabIndex = 11;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(103, 56);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 13);
            this.lblUsername.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(103, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 9;
            // 
            // btnAction
            // 
            this.btnAction.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAction.Location = new System.Drawing.Point(184, 142);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(139, 23);
            this.btnAction.TabIndex = 8;
            this.btnAction.Text = "action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(10, 142);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(145, 23);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "Modifier";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // tbxPwd
            // 
            this.tbxPwd.Location = new System.Drawing.Point(106, 75);
            this.tbxPwd.Name = "tbxPwd";
            this.tbxPwd.PasswordChar = '*';
            this.tbxPwd.Size = new System.Drawing.Size(217, 20);
            this.tbxPwd.TabIndex = 6;
            this.tbxPwd.Visible = false;
            // 
            // lblPwdT
            // 
            this.lblPwdT.AutoSize = true;
            this.lblPwdT.Location = new System.Drawing.Point(7, 82);
            this.lblPwdT.Name = "lblPwdT";
            this.lblPwdT.Size = new System.Drawing.Size(77, 13);
            this.lblPwdT.TabIndex = 5;
            this.lblPwdT.Text = "Mot de passe :";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(106, 49);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(244, 20);
            this.tbxUsername.TabIndex = 4;
            this.tbxUsername.Visible = false;
            // 
            // lblUsernameT
            // 
            this.lblUsernameT.AutoSize = true;
            this.lblUsernameT.Location = new System.Drawing.Point(7, 56);
            this.lblUsernameT.Name = "lblUsernameT";
            this.lblUsernameT.Size = new System.Drawing.Size(90, 13);
            this.lblUsernameT.TabIndex = 3;
            this.lblUsernameT.Text = "Nom d\'utilisateur :";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(106, 23);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(244, 20);
            this.tbxName.TabIndex = 2;
            this.tbxName.Visible = false;
            // 
            // lblNomT
            // 
            this.lblNomT.AutoSize = true;
            this.lblNomT.Location = new System.Drawing.Point(7, 30);
            this.lblNomT.Name = "lblNomT";
            this.lblNomT.Size = new System.Drawing.Size(35, 13);
            this.lblNomT.TabIndex = 0;
            this.lblNomT.Text = "Nom :";
            // 
            // pbxPwdM
            // 
            this.pbxPwdM.Image = global::ATAPP_XML.Properties.Resources.icons8_invisible_24;
            this.pbxPwdM.Location = new System.Drawing.Point(329, 74);
            this.pbxPwdM.Name = "pbxPwdM";
            this.pbxPwdM.Size = new System.Drawing.Size(21, 21);
            this.pbxPwdM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPwdM.TabIndex = 13;
            this.pbxPwdM.TabStop = false;
            this.pbxPwdM.Visible = false;
            this.pbxPwdM.Click += new System.EventHandler(this.pbxNewPwd_Click);
            // 
            // cbxRandomPasswordM
            // 
            this.cbxRandomPasswordM.AutoSize = true;
            this.cbxRandomPasswordM.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbxRandomPasswordM.Location = new System.Drawing.Point(106, 101);
            this.cbxRandomPasswordM.Name = "cbxRandomPasswordM";
            this.cbxRandomPasswordM.Size = new System.Drawing.Size(244, 20);
            this.cbxRandomPasswordM.TabIndex = 16;
            this.cbxRandomPasswordM.Text = "Génération de mot de passe aléatoire";
            this.cbxRandomPasswordM.UseVisualStyleBackColor = true;
            this.cbxRandomPasswordM.Visible = false;
            this.cbxRandomPasswordM.CheckedChanged += new System.EventHandler(this.cbxRandomPasswordM_CheckedChanged);
            // 
            // frmFormulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 196);
            this.Controls.Add(this.gbxFormulaire);
            this.Name = "frmFormulaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFormulaire";
            this.Load += new System.EventHandler(this.frmFormulaire_Load);
            this.gbxFormulaire.ResumeLayout(false);
            this.gbxFormulaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPwdM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFormulaire;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox tbxPwd;
        private System.Windows.Forms.Label lblPwdT;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblUsernameT;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblNomT;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbxPwdM;
        private System.Windows.Forms.CheckBox cbxRandomPasswordM;
    }
}