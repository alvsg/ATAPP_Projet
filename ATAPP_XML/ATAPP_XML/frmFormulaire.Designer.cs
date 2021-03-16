
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.tbxPwd = new System.Windows.Forms.TextBox();
            this.lblPwdT = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblUsernameT = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblNomT = new System.Windows.Forms.Label();
            this.gbxFormulaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFormulaire
            // 
            this.gbxFormulaire.Controls.Add(this.btnAjouter);
            this.gbxFormulaire.Controls.Add(this.lblPwd);
            this.gbxFormulaire.Controls.Add(this.lblUsername);
            this.gbxFormulaire.Controls.Add(this.lblName);
            this.gbxFormulaire.Controls.Add(this.btnSave);
            this.gbxFormulaire.Controls.Add(this.btnModify);
            this.gbxFormulaire.Controls.Add(this.tbxPwd);
            this.gbxFormulaire.Controls.Add(this.lblPwdT);
            this.gbxFormulaire.Controls.Add(this.tbxUsername);
            this.gbxFormulaire.Controls.Add(this.lblUsernameT);
            this.gbxFormulaire.Controls.Add(this.tbxName);
            this.gbxFormulaire.Controls.Add(this.lblNomT);
            this.gbxFormulaire.Location = new System.Drawing.Point(13, 13);
            this.gbxFormulaire.Name = "gbxFormulaire";
            this.gbxFormulaire.Size = new System.Drawing.Size(363, 150);
            this.gbxFormulaire.TabIndex = 0;
            this.gbxFormulaire.TabStop = false;
            this.gbxFormulaire.Text = "Information";
            // 
            // btnAjouter
            // 
            this.btnAjouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAjouter.Location = new System.Drawing.Point(184, 108);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(139, 23);
            this.btnAjouter.TabIndex = 12;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Visible = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(123, 81);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(0, 13);
            this.lblPwd.TabIndex = 11;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(123, 56);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 13);
            this.lblUsername.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(123, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(184, 108);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(10, 108);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(145, 23);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "Modifier";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // tbxPwd
            // 
            this.tbxPwd.Location = new System.Drawing.Point(126, 74);
            this.tbxPwd.Name = "tbxPwd";
            this.tbxPwd.Size = new System.Drawing.Size(197, 20);
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
            this.tbxUsername.Location = new System.Drawing.Point(126, 48);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(197, 20);
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
            this.tbxName.Location = new System.Drawing.Point(126, 23);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(197, 20);
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
            // frmFormulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 172);
            this.Controls.Add(this.gbxFormulaire);
            this.Name = "frmFormulaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFormulaire";
            this.Load += new System.EventHandler(this.frmFormulaire_Load);
            this.gbxFormulaire.ResumeLayout(false);
            this.gbxFormulaire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFormulaire;
        private System.Windows.Forms.Button btnSave;
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
        private System.Windows.Forms.Button btnAjouter;
    }
}