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
    public partial class frmCon : Form
    {
        static string result;
        fileXML file;

        public frmCon()
        {
            InitializeComponent();

            file = new fileXML();
            result = file.VerifyIfExist();
        }

        private void frmCon_Load(object sender, EventArgs e)
        {
            VerifyIfFirstOpen();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            file.Error = null;
            if (tbxConPwd.Text != string.Empty)
            {
                file.ActionOnFile(false, tbxConPwd.Text, "");
                if (file.Error == null)
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
        public void CloseThis(string p)
        {
            this.Hide();
            frmMain form = new frmMain(p);
            form.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Méthode qui permet de vérifier si l'application est ouvert pour la première fois
        /// </summary>
        public void VerifyIfFirstOpen()
        {
            if (result != "1")
            {
                this.Hide();
                frmCreate form = new frmCreate();
                form.ShowDialog();
                this.Close();
            }
        }
    }
}