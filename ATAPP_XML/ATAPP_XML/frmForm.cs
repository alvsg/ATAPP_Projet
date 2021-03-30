﻿using System;
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

        static bool clicked = false;

        public string NameBtn { get => _action; set => _action = value; }
        public Record Enregistrement { get => _enregistrement; }

        Password pwd;

        public frmForm(string btn)
        {
            InitializeComponent();

            pwd = new Password();
            _action = btn;
            _enregistrement = new Record();
        }

        public frmForm(Record fiche, string btn)
        {
            InitializeComponent();

            pwd = new Password();
            _enregistrement = fiche;
            _action = btn;
        }

        private void frmFormulaire_Load(object sender, EventArgs e)
        {
            switch (_action)
            {
                case "ShowData":
                    btnAction.Text = "Enregistrer";
                    lblName.Text = Enregistrement.Name;
                    lblUsername.Text = Enregistrement.Username;
                    for (int pwdLenght = 0; pwdLenght < Enregistrement.Password.Length; pwdLenght++)
                    {
                        lblPwd.Text += "*";
                    }
                    btnAction.Enabled = false;
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

        private void Ajouter()
        {
            if (tbxName.Text != string.Empty && tbxUsername.Text != string.Empty && tbxPwd.Text != string.Empty)
            {
                Enregistrement.Name = tbxName.Text;
                Enregistrement.Password = tbxPwd.Text;
                Enregistrement.Username = tbxUsername.Text;
            }
        }

        public void CloseThis()
        {
            ActiveForm.Close();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (btnAction.Text == "Ajouter")
            {
                Ajouter();
            }
            else
            {
                Save();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            pbxPwdM.Visible = true;
            cbxRandomPasswordM.Visible = true;

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

        public void Save()
        {
            btnModify.Enabled = true;
            btnAction.Visible = false;

            if (Enregistrement.Name == "Biblio-tech")
            {
                if (tbxPwd.Text != Enregistrement.Password)
                {
                    Enregistrement.Password = tbxPwd.Text;
                }

                lblPwd.Visible = true;
                tbxPwd.Visible = false;
            }
            else
            {
                if (tbxName.Text != string.Empty && tbxName.Text != Enregistrement.Name)
                {
                    Enregistrement.Name = tbxName.Text;
                }
                else if (tbxPwd.Text != string.Empty && tbxPwd.Text != Enregistrement.Password)
                {
                    Enregistrement.Password = tbxPwd.Text;
                }
                else if (tbxUsername.Text != string.Empty && tbxUsername.Text != Enregistrement.Username)
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

        private void pbxNewPwd_Click(object sender, EventArgs e)
        {
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

        private void cbxRandomPasswordM_CheckedChanged(object sender, EventArgs e)
        {
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