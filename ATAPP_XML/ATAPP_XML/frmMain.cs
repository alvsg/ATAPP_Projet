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
        static List<int> countFirst, countLast;

        static List<Fiche> data = new List<Fiche>();
        fileXML file;
        Button b;

        public static List<Fiche> Data { get => data; set => data = value; }
        public string Key { get => _key; }

        public frmMain(string s)
        {
            InitializeComponent();

            _key = s;
            file = new fileXML();
            Data = file.GetDataInArray();
            countFirst = Enumerable.Range(0, Data.Count).ToList();
            file.ActionOnFile(true, Key, "writing");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
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
                    //modify
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmFormulaire frmFormulaire = new frmFormulaire("Ajouter");
            frmFormulaire.ShowDialog();
            if (frmFormulaire.DialogResult == DialogResult.OK)
            {
                Fiche f = new Fiche();

                f.Name = frmFormulaire.Fiche.Name;
                f.Username = frmFormulaire.Fiche.Username;
                f.Password = frmFormulaire.Fiche.Password;

                Data.Add(f);
            }
            UpdateView();
        }

        public void UpdateView()
        {
            flowLayoutPanel1.Controls.Clear();

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

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            file.ActionOnFile(false, _key, "writing");
            countLast = Enumerable.Range(0, Data.Count).ToList();
            if (countFirst.Count() != countLast.Count())
            {
                foreach (Fiche f in Data)
                {
                    int first = Data.FindIndex(a => a.Name == f.Name);
                    if(countFirst.Contains(first) == false)
                    {
                        file.InsertDataInFile(f.Username, f.Name, f.Password, first);
                    }
                }
            }
            file.ActionOnFile(true, _key, "");
            this.Close();
        }
    }
}