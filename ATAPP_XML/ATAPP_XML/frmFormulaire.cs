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

        public string NameBtn { get => _action; set => _action = value; }
        public Fiche Fiche { get => _fiche; set => _fiche = value; }

        public frmFormulaire(string btn)
        {
            InitializeComponent();

            _action = btn;
            _fiche = new Fiche();
        }

        public frmFormulaire(Fiche fiche, string btn)
        {
            InitializeComponent();

            _fiche = fiche;
            _action = btn;
        }

        private void frmFormulaire_Load(object sender, EventArgs e)
        {
            switch (_action)
            {
                case "ShowData":
                    lblName.Text = Fiche.Name;
                    lblUsername.Text = Fiche.Username;
                    for (int i = 0; i < Fiche.Password.Length; i++)
                    {
                        lblPwd.Text += "*";
                    }
                    break;

                case "Ajouter":
                    lblName.Visible = false;
                    lblPwd.Visible = false;
                    lblUsername.Visible = false;

                    tbxName.Visible = true;
                    tbxPwd.Visible = true;
                    tbxUsername.Visible = true;

                    btnModify.Visible = false;
                    btnAjouter.Visible = true;
                    break;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
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
            btnSave.Visible = true;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (tbxName.Text != string.Empty && tbxUsername.Text != string.Empty && tbxPwd.Text != string.Empty)
            {
                Fiche.Name = tbxName.Text;
                Fiche.Password = tbxPwd.Text;
                Fiche.Username = tbxUsername.Text;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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

            btnModify.Enabled = true;
            btnSave.Visible = false;
        }

        public void CloseThis()
        {
            ActiveForm.Close();
        }
    }
}
