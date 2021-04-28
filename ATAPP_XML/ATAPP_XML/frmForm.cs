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
    public partial class frmForm : Form
    {
        private Record _enregistrement;
        private string _action;
        private List<Record> _list;

        static bool clicked = false;

        public string NameBtn { get => _action; set => _action = value; }
        public Record Enregistrement { get => _enregistrement; }
        public List<Record> List { get => _list; set => _list = value; }

        Secure pwd;

        public frmForm()
        {

        }

        /// <summary>
        /// Constructeur principal qui prend le bouton préssé
        /// </summary>
        /// <param name="btn"> Le nom du bouton sur lequel l'utilisateur appuié </param>
        public frmForm(string btn)
        {
            InitializeComponent();

            pwd = new Secure();
            _action = btn;
            _enregistrement = new Record();
        }

        public frmForm(Record fiche, string btn, List<Record> record)
        {
            InitializeComponent();

            pwd = new Secure();
            _enregistrement = fiche;
            _action = btn;
            _list = record;
        }

        /// <summary>
        /// Méthode qui permet de définir si l'utilisateur ajoute ou modifie des données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFormulaire_Load(object sender, EventArgs e)
        {
            switch (_action)
            {
                case "ShowData":
                    btnAction.Text = "Supprimer";
                    lblName.Text = Enregistrement.Name;
                    lblUsername.Text = Enregistrement.Username;
                    for (int pwdLenght = 0; pwdLenght < Enregistrement.Password.Length; pwdLenght++)
                    {
                        lblPwd.Text += "*";
                    }
                    break;

                case "Ajouter":
                    pbxPwdM.Visible = true;
                    cbxRandomPasswordM.Visible = true;
                    btnAction.Text = "Ajouter";
                    lblName.Visible = false;
                    lblPwd.Visible = false;
                    lblUsername.Visible = false;

                    tbxName.Visible = true;
                    tbxPwd.Visible = true;
                    tbxUsername.Visible = true;

                    btnModify.Visible = false;
                    break;
            }
        }

        /// <summary>
        /// Méthode qui permet d'ajouter des données
        /// </summary>
        private void Ajouter()
        {
            Enregistrement.Name = tbxName.Text;
            Enregistrement.Password = tbxPwd.Text;
            Enregistrement.Username = tbxUsername.Text;
        }

        /// <summary>
        /// Méthode qui permet de lancer l'ajout ou la sauvegrade (modification) des données lors du clique d'un bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAction_Click(object sender, EventArgs e)
        {
            // Boucle qui vérifie le texte du bouton
            if (btnAction.Text == "Ajouter")
            {
                // Boucle qui vérifie si les champs ne sont pas vide
                if (tbxName.Text != string.Empty && tbxUsername.Text != string.Empty && tbxPwd.Text != string.Empty && tbxName.Text != "Biblio-ch")
                {
                    Ajouter();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (tbxName.Text == "Biblio-ch")
                    {
                        lblMessage.Text = "Entrée incorrect !";
                    }
                    lblMessage.Visible = true;
                }
            }
            else if (btnAction.Text == "Enregistrer")
            {
                Save();
                this.DialogResult = DialogResult.OK;
            }
            else if (btnAction.Text == "Supprimer")
            {
                this.DialogResult = DialogResult.Abort;
            }
        }

        /// <summary>
        /// Méthode qui permet de modifier les données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            btnAction.Text = "Enregistrer";
            pbxPwdM.Visible = true;
            cbxRandomPasswordM.Visible = true;

            // Boucle qui vérifie que ce ne soit pas la première ligne
            if (Enregistrement.Name == "Biblio-tech")
            {
                lblPwd.Visible = false;

                tbxPwd.Visible = true;

                tbxPwd.Text = Enregistrement.Password;
            }
            else
            {
                lblName.Visible = false;
                lblPwd.Visible = false;
                lblUsername.Visible = false;

                tbxName.Visible = true;
                tbxPwd.Visible = true;
                tbxUsername.Visible = true;

                tbxName.Text = Enregistrement.Name;
                tbxUsername.Text = Enregistrement.Username;
                tbxPwd.Text = Enregistrement.Password;
            }

            btnModify.Enabled = false;
            btnAction.Enabled = true;
        }

        /// <summary>
        /// Méthode qui permet de sauvegarder la modificaion des données
        /// </summary>
        public void Save()
        {
            btnModify.Enabled = true;
            btnAction.Visible = false;

            // Boucle qui vérifie que ce ne soit pas la première ligne
            if (Enregistrement.Name == "Biblio-tech")
            {
                // Boucle qui vérifie si le mot de passe dans la textBox de modification n'est pas égale a l'ancien mot de passe 
                if (tbxPwd.Text != Enregistrement.Password)
                {
                    Enregistrement.Password = tbxPwd.Text;
                }

                lblPwd.Visible = true;
                tbxPwd.Visible = false;
            }
            else
            {
                // Boucle qui vérifie si le nom dans la textBox de modification n'est pas égale a l'ancien nom
                if (tbxName.Text != string.Empty && tbxName.Text != Enregistrement.Name)
                {
                    Enregistrement.Name = tbxName.Text;
                }

                // Boucle qui vérifie si le mot de passe dans la textBox de modification n'est pas égale a l'ancien mot de passe 
                if (tbxPwd.Text != string.Empty && tbxPwd.Text != Enregistrement.Password)
                {
                    Enregistrement.Password = tbxPwd.Text;
                }

                // Boucle qui vérifie si le nom d'utilisateur dans la textBox de modification n'est pas égale a l'ancien nom d'utilisateur
                if (tbxUsername.Text != string.Empty && tbxUsername.Text != Enregistrement.Username)
                {
                    Enregistrement.Username = tbxUsername.Text;
                }

                lblName.Visible = true;
                lblPwd.Visible = true;
                lblUsername.Visible = true;

                tbxName.Visible = false;
                tbxPwd.Visible = false;
                tbxUsername.Visible = false;
            }
        }

        /// <summary>
        /// Méthode qui permet d'afficher ou non le mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxNewPwd_Click(object sender, EventArgs e)
        {
            // Boucle qui vérifier si la pictureBox est cliqué
            if (!clicked)
            {
                pbxPwdM.Image = Properties.Resources.icons8_visible_24__1_;
                tbxPwd.PasswordChar = '\0';
                clicked = true;
            }
            else
            {
                pbxPwdM.Image = Properties.Resources.icons8_invisible_24;
                tbxPwd.PasswordChar = '*';
                clicked = false;
            }
        }

        /// <summary>
        /// Méthode qui permet de générer un mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxRandomPasswordM_CheckedChanged(object sender, EventArgs e)
        {
            // Boucle qui permet de vérifier si le comboBox est cliqué
            if (cbxRandomPasswordM.Checked)
            {
                string GeneratedPwd = pwd.GeneratorRandom();
                tbxPwd.Text = GeneratedPwd;
            }
            else
            {
                tbxPwd.Text = "";
            }
        }
    }
}
