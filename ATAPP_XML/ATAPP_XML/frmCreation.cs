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
    public partial class frmCreation : Form
    {
        static bool isClicked1 = false, isClicked2 = false;
        FileXML fileXML;
        Secure pwd;

        /// <summary>
        /// Constructeur principal de la classe frmCreation
        /// </summary>
        public frmCreation()
        {
            InitializeComponent();

            fileXML = new FileXML();
            pwd = new Secure();
        }

        /// <summary>
        /// Méthode qui permet d'ajouter les informations utilisateur de l'application dans le fichier XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetPwd_Click(object sender, EventArgs e)
        {
            // Boucle qui vérifie si les champs ne sont pas vide
            if (tbxNewPwd.Text == tbxConfNewPwd.Text && tbxNewPwd.Text != string.Empty && tbxConfNewPwd.Text != string.Empty)
            {
                fileXML.CreateFile();
                fileXML.InsertDataInFile(fileXML.Username, "Biblio-tech", tbxConfNewPwd.Text, 0);
                CloseThis(tbxConfNewPwd.Text);
            }
            else
            {
                pbxIconMessage.Image = Properties.Resources.icons8_warning_48;
                pbxIconMessage.Visible = true;

                lblMessageError.Text = "Les champs ne sont pas identique ou vide";
                lblMessageError.Visible = true;
            }
        }

        /// <summary>
        /// Méthode qui permet de définir si un mot de passe doit être générer aléatoirement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxRandomPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Boucle qui permet de vérifier si la comboBox est cochée
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
        /// <param name="password"> Le mot de passe de l'utilisateur </param>
        public void CloseThis(string password)
        {
            this.Hide();
            frmMain mainForm = new frmMain(password);
            mainForm.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Méthode qui permet de changer l'image d'une picture box et changer le caractère des champs de mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PbxClicked(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            TextBox textBox = new TextBox();

            var data = ChangeBoolIfClicked(pictureBox, textBox);

            // Boucle qui vérifie si le mot de passe est visible ou non
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
        /// Méthode qui permet d'utiliser la touche entrée pour se connecter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxKeyDown(object sender, KeyEventArgs e)
        {
            // Boucle qui permet de vérifier si la touche préssée est entrer
            if (e.KeyCode == Keys.Enter)
            {
                btnSetPwd.PerformClick();
            }
        }

        /// <summary>
        /// Méthode qui permet, selon le nom de la picture box, de renvoyer un boolean qui représente son état et la textbox correspondante
        /// </summary>
        /// <param name="pictureBox"> une PictureBox </param>
        /// <param name="textBox"> un TextBox </param>
        /// <returns> L'état de la PictureBox </returns>
        public (bool, TextBox) ChangeBoolIfClicked(PictureBox pictureBox, TextBox textBox)
        {
            // Boucle qui vérifie le nom de la pictureBox
            if (pictureBox.Name == "pbxNewPwd")
            {
                textBox = tbxNewPwd;
                return (isClicked1 = !isClicked1, textBox);
            }
            else if (pictureBox.Name == "pbxConfPwd")
            {
                textBox = tbxConfNewPwd;
                return (isClicked2 = !isClicked2, textBox);
            }
            return (false, textBox);
        }
    }
}
