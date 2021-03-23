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
    public partial class frmFormulaire : Form
    {
        private Fiche _fiche;
        private string _action;

        static bool clicked = false;

        public string NameBtn { get => _action; set => _action = value; }
        public Fiche Fiche { get => _fiche; }

        Password pwd;

        public frmFormulaire(string btn)
        {
            InitializeComponent();

            pwd = new Password();
            _action = btn;
            _fiche = new Fiche();
        }

        public frmFormulaire(Fiche fiche, string btn)
        {
            InitializeComponent();

            pwd = new Password();
            _fiche = fiche;
            _action = btn;
        }

        private void frmFormulaire_Load(object sender, EventArgs e)
        {
            switch (_action)
            {
                case "ShowData":
                    btnAction.Text = "Enregistrer";
                    lblName.Text = Fiche.Name;
                    lblUsername.Text = Fiche.Username;
                    for (int i = 0; i < Fiche.Password.Length; i++)
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
                Fiche.Name = tbxName.Text;
                Fiche.Password = tbxPwd.Text;
                Fiche.Username = tbxUsername.Text;
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

            if (Fiche.Name == "Biblio-tech")
            {
                lblPwd.Visible = false;

                tbxPwd.Visible = true;

                tbxPwd.Text = Fiche.Password;
            }
            else
            {
                lblName.Visible = false;
                lblPwd.Visible = false;
                lblUsername.Visible = false;

                tbxName.Visible = true;
                tbxPwd.Visible = true;
                tbxUsername.Visible = true;

                tbxName.Text = Fiche.Name;
                tbxUsername.Text = Fiche.Username;
                tbxPwd.Text = Fiche.Password;
            }

            btnModify.Enabled = false;
            btnAction.Enabled = true;
        }

        public void Save()
        {
            btnModify.Enabled = true;
            btnAction.Visible = false;

            if (Fiche.Name == "Biblio-tech")
            {
                if (tbxPwd.Text != Fiche.Password)
                {
                    Fiche.Password = tbxPwd.Text;
                }

                lblPwd.Visible = true;
                tbxPwd.Visible = false;
            }
            else
            {
                if (tbxName.Text != string.Empty && tbxName.Text != Fiche.Name)
                {
                    Fiche.Name = tbxName.Text;
                }
                else if (tbxPwd.Text != string.Empty && tbxPwd.Text != Fiche.Password)
                {
                    Fiche.Password = tbxPwd.Text;
                }
                else if (tbxUsername.Text != string.Empty && tbxUsername.Text != Fiche.Username)
                {
                    Fiche.Username = tbxUsername.Text;
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
