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
    public partial class frmMain : Form
    {
        private string _key;
         
        List<Fiche> data = new List<Fiche>();
        fileXML file;
        Button b;

        public List<Fiche> Data { get => data; set => data = value; }
        public string Key { get => _key; set => _key = value; }

        public frmMain()
        {
            InitializeComponent();
            file = new fileXML();

            Data = file.GetDataInArray();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            file.ActionOnFile(true, Data[0].Password);
            UpdateView();
        }

        private void btnFlp_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                Fiche fiche = Data.Where(f => f.Name == btn.Name).First();
                frmFormulaire frm = new frmFormulaire(fiche, "ShowData");
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.OK)
                {
                    //Modify
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmFormulaire frmFormulaire = new frmFormulaire("Ajouter");
            frmFormulaire.ShowDialog();
            if (frmFormulaire.DialogResult == DialogResult.OK)
            {
                string username = frmFormulaire.Fiche.Username;
                string name = frmFormulaire.Fiche.Name;
                string pwd = frmFormulaire.Fiche.Password;

                file.ActionOnFile(false, Key);
                file.InsertDataInFile(username, name, pwd, 1);
                Data.Add(new Fiche(username, pwd, name));
                flowLayoutPanel1.Controls.Clear();
                UpdateView();
                file.ActionOnFile(true, Key);
            }
        }

        public void UpdateView()
        {
            foreach (Fiche fiche in Data)
            {
                b = new Button();
                b.Name = fiche.Name;
                b.Text = fiche.Name;
                b.FlatStyle = FlatStyle.Flat;
                b.Width = 167;
                b.Height = 79;
                b.Click += btnFlp_Click;
                flowLayoutPanel1.Controls.Add(b);
            }
        }
    }
}