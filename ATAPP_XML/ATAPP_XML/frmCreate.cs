/*
 * PROJET : Bilbio-tech
 * AUTEUR : ALVES GUASTTI Letitia (I.FA-P3A)
 * DESC. : Un gestionnaire de mot de passe
 * VERSION : 26.01.2021 v.1
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATAPP_XML
{
    public partial class frmCreate : Form
    {
        static bool isClicked1 = false, isClicked2 = false;
        fileXML file;
        Password pwd;

        public frmCreate()
        {
            InitializeComponent();

            file = new fileXML();
            pwd = new Password();
        }

        private void btnSetPwd_Click(object sender, EventArgs e)
        {
            if (tbxNewPwd.Text == tbxConfNewPwd.Text && tbxNewPwd.Text != string.Empty && tbxConfNewPwd.Text != string.Empty)
            {
                file.InsertDataInFile(file.Username, tbxConfNewPwd.Text);
                CloseThis();
            }
            else
            {
                pbxIconMessage.Image = Properties.Resources.icons8_warning_48;
                pbxIconMessage.Visible = true;

                lblMessageError.Text = "Les champs ne sont pas identique ou vide";
                lblMessageError.Visible = true;
            }
        }

        private void cbxRandomPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxRandomPassword.Checked)
            {
                string GeneratedPwd = pwd.GeneratorRandom();

                tbxNewPwd.Text = GeneratedPwd;
                tbxConfNewPwd.Text = GeneratedPwd;

                pbxIconMessage.Image = Properties.Resources.icons8_aide_48;
                pbxIconMessage.Visible = true;

                lblMessageError.Text = "Veuillez prendre note du mot de passe";
                lblMessageError.Visible = true;
            }
            else
            {
                tbxNewPwd.Text = string.Empty;
                tbxConfNewPwd.Text = string.Empty;

                lblMessageError.Visible = false;
                pbxIconMessage.Visible = false;
            }
        }

        /// <summary>
        /// Méthode qui permet de fermer le formulaire de connexion et d'ouvrir le formulaire principal
        /// </summary>
        public void CloseThis()
        {
            this.Hide();
            frmMain form = new frmMain(tbxConfNewPwd.Text);
            pwd.CopyToClipboard(tbxConfNewPwd);
            form.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Méthode qui permet de changer l'image d'une picture box et changer le caractère des champs de mot de passe
        /// </summary>
        /// <param name="pictureBox"> une PictureBox </param>
        /// <param name="tbx"> un TextBox </param>
        public void PbxClicked(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            TextBox textBox = new TextBox();

            var data = ChangeBoolIfClicked(pictureBox, textBox);

            if (data.Item1 == true)
            {
                pictureBox.Image = Properties.Resources.icons8_visible_24__1_;
                data.Item2.PasswordChar = '\0';
            }
            else
            {
                pictureBox.Image = Properties.Resources.icons8_invisible_24;
                data.Item2.PasswordChar = '*';
            }
        }

        /// <summary>
        /// Méthode qui permet, selon le nom de la picture box, de renvoyer un boolean qui représente son état et la textbox correspondante
        /// </summary>
        /// <param name="pbx"> une PictureBox </param>
        /// <param name="tbx"> un TextBox </param>
        /// <returns> L'état de la PictureBox </returns>
        public (bool, TextBox) ChangeBoolIfClicked(PictureBox pbx, TextBox tbx)
        {
            if (pbx.Name == "pbxNewPwd")
            {
                tbx = tbxNewPwd;
                return (isClicked1 = !isClicked1, tbx);
            }
            else if (pbx.Name == "pbxConfPwd")
            {
                tbx = tbxConfNewPwd;
                return (isClicked2 = !isClicked2, tbx);
            }
            return (false, tbx);
        }
    }
}
