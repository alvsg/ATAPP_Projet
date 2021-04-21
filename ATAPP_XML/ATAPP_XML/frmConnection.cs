﻿/*
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

        public frmConnection()
        {
            InitializeComponent();

            file = new FileXML();
            password = new Secure();
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
            password.Error = null;
            if (tbxConPwd.Text != string.Empty)
            {
                password.ActionOnFile(false, tbxConPwd.Text, "");
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
            if (!result)
            {
                this.Hide();
                frmCreation form = new frmCreation();
                form.ShowDialog();
                this.Close();
            }
        }

        private void tbxConPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCon.PerformClick();
            }
        }
    }
}