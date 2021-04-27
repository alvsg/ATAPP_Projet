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
using System.IO; //Added
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATAPP_XML
{
    public partial class frmConnection : Form
    {
        static bool result;
        FileXML file;
        Secure password;

        /// <summary>
        /// Constructeur principal de la classe frmConnection
        /// </summary>
        public frmConnection()
        {
            InitializeComponent();

            file = new FileXML();
            password = new Secure();
            result = file.VerifyIfExist();
        }

        /// <summary>
        /// Méthode qui permet lors de l'ouverture si l'application est ouverte pour la première fois
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCon_Load(object sender, EventArgs e)
        {
            VerifyIfFirstOpen();
        }

        /// <summary>
        /// Méthode qui permet de quitter l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Méthode qui permet de se connecter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCon_Click(object sender, EventArgs e)
        {
            password.Error = null;
            // Boucle qui vérifie que le champs n'est pas vide
            if (tbxConPwd.Text != string.Empty)
            {
                password.ActionOnFile(false, tbxConPwd.Text, "");
                // Boucle qui vérifie qu'il n'y est aucune erreur
                if (password.Error == null)
                {
                    CloseThis(tbxConPwd.Text);
                }
                else
                {
                    pbxWarning.Visible = true;
                    lblWarning.Visible = true;
                }
            }
        }

        /// <summary>
        /// Méthode qui permet de fermer le formulaire de connexion et d'ouvrir le formulaire principal
        /// </summary>
        public void CloseThis(string password)
        {
            this.Hide();
            frmMain form = new frmMain(password);
            form.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Méthode qui permet de vérifier si l'application est ouvert pour la première fois
        /// </summary>
        public void VerifyIfFirstOpen()
        {
            // Boucle qui vérifie le resultat
            if (!result)
            {
                this.Hide();
                frmCreation form = new frmCreation();
                form.ShowDialog();
                this.Close();
            }
        }

        /// <summary>
        /// Méthode qui permet de se connecter en appuyant sur la touche Entrer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxConPwd_KeyDown(object sender, KeyEventArgs e)
        {
            // Boucle qui vérifie si la touche est la touche Entrer
            if (e.KeyCode == Keys.Enter)
            {
                btnCon.PerformClick();
            }
        }
    }
}